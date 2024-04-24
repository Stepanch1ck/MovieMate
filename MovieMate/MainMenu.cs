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
        MovieDbContext db = new MovieDbContext();
        public MainMenu()
        {

            InitializeComponent();
        }

        private void russianButton_Click(object sender, EventArgs e)
        {

        }
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void filmsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var allFilms = db.Movies.ToList();
            var person = db.People.ToList();
            filmsDataGridView.DataSource = allFilms;
            filmsDataGridView.Refresh();
            int idMovieLike = person[0].IdMovieLike;
            DisplayMoviesByGenre(idMovieLike);

        }
        private void DisplayMoviesByGenre(string selectedMovieId)
        {
            using (var context = new MovieDbContext())
            {
                // Retrieve the selected movie
                var selectedMovie = context.Movies.FirstOrDefault(m => m.Name == selectedMovieId);
                if (selectedMovie == null)
                {
                    return; // Movie not found
                }
                var genre = selectedMovie.Genre;
                var moviesWithSameGenre = context.Movies
                    .Where(m => m.Genre == genre)
                    .ToList();
                filmsDataGridView.Rows.Clear();
                foreach (var movieItem in moviesWithSameGenre)
                {
                    filmsDataGridView.Rows.Add(movieItem.Name, movieItem.Year, movieItem.Grade);
                }
            }
        }
        private void filmsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Получение информации о фильме из выбранной строки
            int selectedMovieId = Convert.ToInt32(filmsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);


        }
        private void openButton_Click(object sender, EventArgs e)
        {
            var movieDetailsForm = new MovieCard(selectedMovieId);
            movieDetailsForm.Show();
            this.Close();
        }
        
    }
}
