using MovieMate.DBConnect;
using NLog;

namespace MovieMate.AfterEnterForms
{
    public partial class MovieListComp : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string selectedMovie = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;
        public MovieListComp(Compilation compilation)
        {
            InitializeComponent();
            currentCompilation = compilation;
            LoadMovieListBox();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedItems.Count > 0)
            {
                selectedMovie = MovieListBox.SelectedItem.ToString();
            }
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            var movadd = new addMovie(currentCompilation);
            movadd.Show();
            this.Close();
            logger.Info($"Открытие формы добавления фильма в {currentCompilation.Name}.");
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Кнопка 'Удалить фильм' нажата.");
                if (MovieListBox.SelectedItems.Count > 0)
                {
                    var selectedmov = (Movie)MovieListBox.SelectedItem;

                    List<int> movIds = new List<int>();
                    string[] movIdStrings = currentCompilation.IdMovie.Split(',');
                    foreach (var movIdString in movIdStrings)
                    {
                        if (int.TryParse(movIdString, out int movId))
                        {
                            movIds.Add(movId);
                        }
                    }
                    movIds.Remove(selectedmov.Id);
                    currentCompilation.IdPerson = string.Join(",", movIds);

                    MovieListBox.Items.Clear();
                    foreach (var movId in currentCompilation.IdMovie.Split(','))
                    {
                        var movieId = int.Parse(movId);
                        var movie = db.Movies.Find(movieId);
                        if (movie != null)
                        {
                            MovieListBox.Items.Add(movie);
                        }
                    }
                }
                else
                {
                    logger.Warn("Пользователь пытается удалить фильм, но не выбрал фильм.");
                    MessageBox.Show("Пожалуйста, выберите фильм.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при удалении фильма.");
                MessageBox.Show("Произошла ошибка при удалении фильма. Пожалуйста, попробуйте снова.");
            }
        }

        private void LoadMovieListBox()
        {
            try
            {
                logger.Info("Загрузка списка фильмов.");
                MovieListBox.Items.Clear();
                MovieListBox.DisplayMember = "Name";

                if (string.IsNullOrEmpty(currentCompilation.IdMovie))
                {
                    return;
                }
                string[] movIdStrings = currentCompilation.IdMovie.Split(',');

                foreach (string movIdString in movIdStrings)
                {
                    if (int.TryParse(movIdString, out int movId))
                    {
                        var mov = db.Movies.Find(movId);
                        if (mov != null)
                        {
                            MovieListBox.Items.Add(mov);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке списка фильмов.");
                MessageBox.Show("Произошла ошибка при загрузке списка фильмов. Пожалуйста, попробуйте снова.");
            }
        }
    }
}
