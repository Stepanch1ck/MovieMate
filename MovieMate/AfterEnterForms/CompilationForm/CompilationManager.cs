using MovieMate.DBConnect;
using NLog;

namespace MovieMate.AfterEnterForms.CompilationForm
{
    public class CompilationManager
    {
        private MovieDbContext db;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public CompilationManager(MovieDbContext dbContext)
        {
            db = dbContext;
        }

        public void AddMovieToCompilation(Compilation compilation, int movieId, int currentUserId)
        {
            try
            {
                logger.Info($"Добавление фильма с Id{movieId} в подборку с ID {compilation.Id}");
                var blacklistedByOthers = db.People.Any(p =>
                    p.Id != currentUserId &&
                    !string.IsNullOrEmpty(p.IdBlackList) &&
                    p.IdBlackList.IndexOf($",{movieId},") != -1);
                if (blacklistedByOthers)
                {
                    logger.Warn($"Фильм с ID {movieId} у других пользователей в черном списке.");
                    return;
                }
                if (string.IsNullOrEmpty(compilation.IdMovie))
                {
                    compilation.IdMovie = movieId.ToString();
                }
                else if (!compilation.IdMovie.Split(',').Contains(movieId.ToString()))
                {
                    compilation.IdMovie += "," + movieId;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка добавления фильма с ID {movieId} в подборку.");
                throw;
            }
        }

        public void RemoveMovieFromCompilation(Compilation compilation, int movieId)
        {
            try
            {
                logger.Info($"Удаление фильма с ID {movieId} from compilation with ID {compilation.Id}");
                if (string.IsNullOrEmpty(compilation.IdMovie))
                {
                    logger.Warn($"Подборка с ID {compilation.Id} не содержит фильмов.");
                    return;
                }
                var movieIds = compilation.IdMovie.Split(',').ToList();
                if (movieIds.Contains(movieId.ToString()))
                {
                    movieIds.Remove(movieId.ToString());
                    compilation.IdMovie = string.Join(",", movieIds);
                    db.SaveChanges();
                    logger.Info($"Фильм с ID {movieId} удален из компиляции с ID {compilation.Id}");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка удаления фильма с ID {movieId} из компиляции.");
                throw;
            }
        }
        public void CheckAndRemoveBlacklistedMovies(Compilation compilation)
        {
            try
            {
                logger.Info($"Проверка и удаление фильмов с черных списков из подборки с ID {compilation.Id}");
                if (string.IsNullOrEmpty(compilation.IdMovie))
                {
                    logger.Warn($"Подборка с ID {compilation.Id} без фильмов.");
                    return;
                }
                var movieIds = compilation.IdMovie.Split(',').Select(int.Parse).ToList();
                foreach (var movieId in movieIds)
                {
                    if (IsMovieBlacklisted(movieId))
                    {
                        RemoveMovieFromCompilation(compilation, movieId);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка проверки и удаления фильмов с черных списков.");
                throw;
            }
        }

        private bool IsMovieBlacklisted(int movieId, int currentUserId = -1)
        {
            try
            {
                return db.People.Any(p =>
                    (currentUserId == -1 || p.Id != currentUserId) &&
                    !string.IsNullOrEmpty(p.IdBlackList) &&
                    p.IdBlackList.IndexOf($",{movieId},") != -1);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка проверки есть ли фильм с ID {movieId} в черном списке.");
                throw;
            }
        }

        public void CheckAndRemoveFromCompilationIfNotInFavorites(Compilation compilation, int movieId, int userId)
        {
            try
            {
                logger.Info($"Проверка и удаление фильма с ID {movieId}");
                var user = db.People.FirstOrDefault(p => p.Id == userId);
                if (user == null || string.IsNullOrEmpty(user.IdFavorites) || !user.IdFavorites.Split(',').Contains(movieId.ToString()))
                {
                    RemoveMovieFromCompilation(compilation, movieId);
                    logger.Info($"Фильм с ID {movieId} удален с подборки с ID {compilation.Id}.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка проверки и удаления фильма с ID {movieId}.");
                throw;
            }
        }
    }
}
