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
        }

        private void russianButton_Click(object sender, EventArgs e)
        {

        }
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string idMovieLike = currentUser.IdMovieLike;
            DisplaySimilarMovies(idMovieLike);
        }

        private void filmsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var allFilms = db.Movies.ToList();
            filmsDataGridView.DataSource = allFilms;
            filmsDataGridView.Refresh();
            
        }
        private void DisplayMoviesByGenre(string movieName)
        {
            using (var context = new MovieDbContext())
            {

                var movie = context.Movies.FirstOrDefault(m => m.Name == movieName);
                if (movie == null)
                {
                    return;
                }

                var genreId = movie.Genre; 
                var moviesWithSameGenre = context.Movies
                    .Where(m => m.Genre == genreId)
                    .ToList();
                filmsDataGridView.Rows.Clear();

                foreach (var movieItem in moviesWithSameGenre)
                {
                    filmsDataGridView.Rows.Add(movieItem.Name,movieItem.Year, movieItem.Grade);
                }
            }
        }
        private void DisplaySimilarMovies(string idMovieLike)
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

    }
}
