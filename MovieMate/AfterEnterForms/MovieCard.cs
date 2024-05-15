using MovieMate.DBConnect;
using NLog;

namespace MovieMate
{
    public partial class MovieCard : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly int selectedMovieId;
        private Movie selectedMovie;
        MovieDbContext db = new MovieDbContext();

        public MovieCard(int movieId)
        {
            InitializeComponent();
            selectedMovieId = movieId;
            LoadMovieDetails();
        }

        private void LoadMovieDetails()
        {
            try
            {
                selectedMovie = db.Movies.FirstOrDefault(m => m.Id == selectedMovieId);

                if (selectedMovie != null)
                {
                    logger.Info($"Загружены данные о фильме: {selectedMovie.Name}");
                    label8.Text = $"Название: {selectedMovie.Name}";
                    label4.Text = $"Жанр: {selectedMovie.Genre}";
                    label5.Text = $"Оценка: {selectedMovie.Grade}";
                    label6.Text = selectedMovie.Link;

                    if (selectedMovie.Picture != null)
                    {
                        moviePictureBox.Image = Image.FromStream(new MemoryStream(selectedMovie.Picture));
                    }
                }
                else
                {
                    logger.Error($"Фильм с ID {selectedMovieId} не найден.");
                    MessageBox.Show("Фильм не найден!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Произошла ошибка при загрузке данных о фильме."); 
                MessageBox.Show("Произошла ошибка при загрузке данных о фильме.");
                this.Close();
            }
        }
    }
}
