using MovieMate.DBConnect;

namespace MovieMate
{
    public partial class MovieCard : Form
    {
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
            selectedMovie = db.Movies.FirstOrDefault(m => m.Id == selectedMovieId);

            if (selectedMovie != null)
            {
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
                MessageBox.Show("Фильм не найден!");
                this.Close();
            }
        }

   
    }
}
