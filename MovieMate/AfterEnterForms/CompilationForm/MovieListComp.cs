using MovieMate.DBConnect;

namespace MovieMate.AfterEnterForms
{
    public partial class MovieListComp : Form
    {
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
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Пожалуйста, выберите фильм.");
            }
        }

        private void LoadMovieListBox()
        {
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
    }
}
