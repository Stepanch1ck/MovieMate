using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieMate.DBConnect;

namespace MovieMate
{
    public partial class FavouritesListForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Movie selectedMovie;
        public FavouritesListForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idFavorites = currentUser.IdFavorites;
            DisplaySimilarMovies(idFavorites);
        }

        private void FavouritesListForm_Load(object sender, EventArgs e)
        {
            var idFavorites = currentUser.IdFavorites;
            DisplaySimilarMovies(idFavorites);
        }

        private void DisplaySimilarMovies(string idFavorites)
        {
            if (string.IsNullOrEmpty(idFavorites))
            {
                FavouritesDataGridView.Rows.Clear();
                return;
            }
            List<int> movieIds = idFavorites.Split(',').Select(int.Parse).ToList();
            var similarMovies = db.Movies
             .Where(m => movieIds.Contains(m.Id))
             .ToList();
            FavouritesDataGridView.Rows.Clear();
            foreach (var movie in similarMovies)
            {
                FavouritesDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
            }
        }

        private void deleteFromFavouritesButton_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Выберите фильм для удаления из избранного!");
                return;
            }
            List<int> movieIds = currentUser.IdFavorites.Split(',').Select(int.Parse).ToList();
            movieIds.Remove(selectedMovie.Id);
            currentUser.IdFavorites = string.Join(",", movieIds);
            if (currentUser.IdFavorites.StartsWith(","))
            {
                currentUser.IdFavorites = currentUser.IdFavorites.Substring(1);
            }
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdFavorites);

            MessageBox.Show("Фильм удален из избранного!");
        }

        private void blackListButton_Click(object sender, EventArgs e)
        {
            BlackListForm blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            this.Close();
        }
        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FavouritesDataGridView.Rows[e.RowIndex].Selected = true;

                string selectedMovieName = FavouritesDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                int selectedMovieYear = Convert.ToInt32(FavouritesDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
            }
        }

        private void openFavouritesButton_Click(object sender, EventArgs e)
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
    }
}
