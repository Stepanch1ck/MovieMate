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

    }
}
