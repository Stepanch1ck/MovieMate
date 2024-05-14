using System.Data;
using MovieMate.AfterEnterForms.CompilationForm;
using MovieMate.DBConnect;

namespace MovieMate
{
    public partial class BlackListForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Movie selectedMovie;
        CompilationManager compilationManager;
        Compilation defaultCompilation;
        public BlackListForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idBlackList = currentUser.IdBlackList;
            DisplaySimilarMovies(idBlackList);
            compilationManager = new CompilationManager(db);
            defaultCompilation = db.Compilations.FirstOrDefault(c => c.Id == 1);
        }

        private void BlackListForm_Load(object sender, EventArgs e)
        {
            var idBlackList = currentUser.IdBlackList;
            DisplaySimilarMovies(idBlackList);
        }

        private void DisplaySimilarMovies(string idBlackList)
        {
            if (string.IsNullOrEmpty(idBlackList))
            {
                BlackListDataGridView.Rows.Clear();
                return;
            }
            List<int> movieIds = idBlackList.Split(',').Select(int.Parse).ToList();
            var similarMovies = db.Movies
             .Where(m => movieIds.Contains(m.Id))
             .ToList();
            BlackListDataGridView.Rows.Clear();
            foreach (var movie in similarMovies)
            {
                BlackListDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var favoritesListForm = new FavouritesListForm(UserNickname);
            favoritesListForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            this.Close();
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BlackListDataGridView.Rows[e.RowIndex].Selected = true;

                var selectedMovieName = BlackListDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                var selectedMovieYear = Convert.ToInt32(BlackListDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Пожалуйста выберите фильм!");
                return;
            }

            var selectedMovieId = selectedMovie.Id;
            var movieDetailsForm = new MovieCard(selectedMovieId);
            movieDetailsForm.Show();
        }

        private void deleteBlackList_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Выберите фильм для удаления из чёрного списка!");
                return;
            }
            List<int> movieIds = currentUser.IdBlackList.Split(',').Select(int.Parse).ToList();
            movieIds.Remove(selectedMovie.Id);
            currentUser.IdBlackList = string.Join(",", movieIds);
            if (currentUser.IdBlackList.StartsWith(","))
            {
                currentUser.IdBlackList = currentUser.IdBlackList.Substring(1);
            }
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdBlackList);
            compilationManager.AddMovieToCompilation(defaultCompilation, selectedMovie.Id, currentUser.Id);

            MessageBox.Show("Фильм удален из чёрного списка!");
        }

        private void generalCompilationButton_Click(object sender, EventArgs e)
        {
            var gf = new GeneralCompilationForm(UserNickname);
            gf.Show();
            this.Close();
        }
    }

}

