using MovieMate.DBConnect;

namespace MovieMate.AfterEnterForms.CompilationForm
{
    public class CompilationManager
    {
        private MovieDbContext db;

        public CompilationManager(MovieDbContext dbContext)
        {
            db = dbContext;
        }

        public void AddMovieToCompilation(Compilation compilation, int movieId, int currentUserId)
        {
            var blacklistedByOthers = db.People.Any(p =>
                p.Id != currentUserId &&
                !string.IsNullOrEmpty(p.IdBlackList) &&
                p.IdBlackList.IndexOf($",{movieId},") != -1);

            if (blacklistedByOthers) return;

            if (string.IsNullOrEmpty(compilation.IdMovie))
            {
                compilation.IdMovie = movieId.ToString();
            }
            else if (!compilation.IdMovie.Split(',').Contains(movieId.ToString()))
            {
                compilation.IdMovie += "," + movieId;
            }
        }

        public void RemoveMovieFromCompilation(Compilation compilation, int movieId)
        {
            if (string.IsNullOrEmpty(compilation.IdMovie)) return;

            var movieIds = compilation.IdMovie.Split(',').ToList();
            if (movieIds.Contains(movieId.ToString()))
            {
                movieIds.Remove(movieId.ToString());
                compilation.IdMovie = string.Join(",", movieIds);
                db.SaveChanges();
            }
        }
        public void CheckAndRemoveBlacklistedMovies(Compilation compilation)
        {
            if (string.IsNullOrEmpty(compilation.IdMovie)) return;

            var movieIds = compilation.IdMovie.Split(',').Select(int.Parse).ToList();
            foreach (var movieId in movieIds.ToList())
            {
                if (IsMovieBlacklisted(movieId))
                {
                    RemoveMovieFromCompilation(compilation, movieId);
                }
            }
        }

        private bool IsMovieBlacklisted(int movieId, int currentUserId = -1)
        {
            return db.People.Any(p =>
                (currentUserId == -1 || p.Id != currentUserId) &&
                !string.IsNullOrEmpty(p.IdBlackList) &&
                p.IdBlackList.IndexOf($",{movieId},") != -1);
        }

        public void CheckAndRemoveFromCompilationIfNotInFavorites(Compilation compilation, int movieId, int userId)
        {
            var user = db.People.FirstOrDefault(p => p.Id == userId);
            if (user == null || string.IsNullOrEmpty(user.IdFavorites) || !user.IdFavorites.Split(',').Contains(movieId.ToString()))
            {
                RemoveMovieFromCompilation(compilation, movieId);
            }
        }
    }
}
