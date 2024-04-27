using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMate
{

    public partial class MainMenu : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        public MainMenu(string nickname)
        {

            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idMovieLike = currentUser.IdMovieLike;
            DisplaySimilarMovies(idMovieLike);
            secondNicknameLabel.Text = nickname;
        }

        void russianButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("US");

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
            // Получение информации о фильме из выбранной строки
            var selectedMovieId = Convert.ToInt32(filmsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            

        }
        void openButton_Click(object sender, EventArgs e)
        {
            //var movieDetailsForm = new MovieCard(selectedMovieId);
            //movieDetailsForm.Show();
            //this.Close();
        }
        void DisplaySimilarMovies(string idMovieLike)
        {
            // Разделить строку IdMovieLike на список ID
            List<int> movieIds = idMovieLike.Split(',').Select(int.Parse).ToList();

            // Получить жанры понравившихся фильмов
            var likedGenres = db.Movies
                .Where(m => movieIds.Contains(m.Id))
                .Select(m => m.Genre)
                .Distinct()
                .ToList();

            // Найти фильмы с похожими жанрами, исключая уже понравившиеся
            var similarMovies = db.Movies
                .Where(m => likedGenres.Contains(m.Genre) && !movieIds.Contains(m.Id))
                .ToList();

            // Очистить DataGridView и заполнить его похожими фильмами
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

        void englishButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru");
        }

        private void addToFavouritesButton_Click(object sender, EventArgs e)
        {
            int selectedMovieId = Convert.ToInt32(filmsDataGridView.Rows[filmsDataGridView.CurrentCell.RowIndex].Cells["Id"].Value);
            currentUser.IdFavorites += "," + selectedMovieId;
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdMovieLike);
        }

        private void addToBlackListButton_Click(object sender, EventArgs e)
        {
            int selectedMovieId = Convert.ToInt32(filmsDataGridView.Rows[filmsDataGridView.CurrentCell.RowIndex].Cells["Id"].Value);
            currentUser.IdBlackList += "," + selectedMovieId;
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdBlackList);
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            BlackListForm blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
        }

        
    }
}
