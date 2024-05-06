using MovieMate.DBConnect;
using System.Data;

namespace MovieMate
{

    public partial class MainMenu : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Movie selectedMovie;
        public MainMenu(string nickname)
        {

            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idMovieLike = currentUser.IdMovieLike;
            DisplaySimilarMovies(idMovieLike);
            secondNicknameLabel.Text = nickname;
        }




        void MainMenu_Load(object sender, EventArgs e)
        {
            var idMovieLike = currentUser.IdMovieLike;
            DisplaySimilarMovies(idMovieLike);
        }

        void filmsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var allFilms = db.Movies.ToList();
            filmsDataGridView.DataSource = allFilms;
            filmsDataGridView.Refresh();

        }

        void filmsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedMovieId = Convert.ToInt32(filmsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            Movie selectedMovie = db.Movies.Find(selectedMovieId);
            var idMovieLike = currentUser.IdMovieLike;
            DisplaySimilarMovies(idMovieLike);

        }

        void DisplaySimilarMovies(string idMovieLike)
        {
            if (string.IsNullOrEmpty(idMovieLike))
            {
                var allMovies = db.Movies.ToList();
                filmsDataGridView.Rows.Clear();
                foreach (var movie in allMovies)
                {
                    filmsDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
                }
                return;

            }
            List<int> movieIds = idMovieLike.Split(',').Select(int.Parse).ToList();

            var likedGenres = db.Movies
                .Where(m => movieIds.Contains(m.Id))
                .Select(m => m.Genre)
                .Distinct()
                .ToList();

            var similarMovies = db.Movies
                .Where(m => likedGenres.Contains(m.Genre) && !movieIds.Contains(m.Id))
                .ToList();

            filmsDataGridView.Rows.Clear();
            foreach (var movie in similarMovies)
            {
                filmsDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
            }
        }



        void favoritesButton_Click(object sender, EventArgs e)
        {
            var favouritesListForm = new FavouritesListForm(UserNickname);
            favouritesListForm.Show();
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            BlackListForm blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filmsDataGridView.Rows[e.RowIndex].Selected = true;

                string selectedMovieName = filmsDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                int selectedMovieYear = Convert.ToInt32(filmsDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
            }
        }

        private void openButton_Click_1(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Пожалуйста выберите фильм!");
                return;
            }

            int selectedMovieId = selectedMovie.Id;
            var movieDetailsForm = new MovieCard(selectedMovieId);
            movieDetailsForm.Show();
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Выберите фильм двойным кликом!");
                return;
            }
            if (currentUser.IdFavorites != null && currentUser.IdFavorites.Contains(selectedMovie.Id.ToString()))
            {
                MessageBox.Show("Этот фильм уже в избранном!");
                return;
            }
            if (currentUser.IdFavorites == null)
            {
                currentUser.IdFavorites = selectedMovie.Id.ToString();
            }
            else
            {
                currentUser.IdFavorites += "," + selectedMovie.Id;
            }
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdMovieLike);

            MessageBox.Show("Фильм добавлен в избранное!");
        }

        private void addBlackListButton_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Выберите фильм двойным кликом!");
                return;
            }
            if (currentUser.IdBlackList != null && currentUser.IdBlackList.Contains(selectedMovie.Id.ToString()))
            {
                MessageBox.Show("Этот фильм уже в чёрном списке!");
                return;
            }
            if (currentUser.IdBlackList == null)
            {
                currentUser.IdBlackList = selectedMovie.Id.ToString();
            }
            else
            {
                currentUser.IdBlackList += "," + selectedMovie.Id;
            }
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdMovieLike);

            MessageBox.Show("Фильм добавлен в чёрный список!");
        }

        private void generalCompilationButton_Click(object sender, EventArgs e)
        {
            GeneralCompilationForm gf = new GeneralCompilationForm();
            gf.Show();
            this.Close();
        }

        private void secondNicknameLabel_Click(object sender, EventArgs e)
        {
            UserInfo info = new UserInfo();
            info.Show();
        }
    }
}
