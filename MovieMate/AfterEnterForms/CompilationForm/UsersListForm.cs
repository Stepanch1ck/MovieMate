using MovieMate.DBConnect;
using NLog;
using System.Data;

namespace MovieMate
{
    public partial class UsersListForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        MovieDbContext db = new MovieDbContext();

        public UsersListForm(Compilation compilation)
        {
            InitializeComponent();
            DisplaySimilarCompilation(compilation);
            menuLabel.Text=compilation.Name;
        }

        public void DisplaySimilarCompilation(Compilation compilation)
        {
            try
            {
                logger.Info($"Запущен метод DisplaySimilarCompilation для компиляции {compilation.Name}");

                if (compilation == null || string.IsNullOrEmpty(compilation.IdMovie))
                {
                    logger.Warn($"Компиляция пустая или IdMovie пустой, очистка данных.");
                    filmsDataGridView.Rows.Clear();
                    return;
                }

                List<int> movieIds = compilation.IdMovie.Split(',')
                    .Where(idStr => !string.IsNullOrEmpty(idStr))
                    .Select(int.Parse)
                    .ToList();

                var movies = db.Movies.Where(m => movieIds.Contains(m.Id)).ToList();

                logger.Debug($"Найдено {movies.Count} фильмов для компиляции.");

                filmsDataGridView.Rows.Clear();
                if (filmsDataGridView.Columns.Count == 0)
                {
                    logger.Info($"Добавление столбцов в таблицу.");
                    filmsDataGridView.Columns.Add("MovieName", "Movie Name");
                    filmsDataGridView.Columns.Add("Year", "Year");
                    filmsDataGridView.Columns.Add("Grade", "Grade");
                }

                foreach (var movie in movies)
                {
                    logger.Debug($"Добавление фильма {movie.Name} в таблицу.");
                    filmsDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при отображении компиляции: {ex.Message}");
                MessageBox.Show("Произошла ошибка при отображении данных.");
            }
        }
    }
}
