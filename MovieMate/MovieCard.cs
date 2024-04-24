using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMate
{
    public partial class MovieCard : Form
    {
        private readonly int selectedMovieId;
        public MovieCard(int movieId)
        {
            InitializeComponent();
            selectedMovieId = movieId;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private Movie GetMovieDetails(int movieId)
        {
            return new Movie();
        }
        private void MovieCard_Load(object sender, EventArgs e)
        {
            var movie = GetMovieDetails(selectedMovieId); 
            label8.Text = $"Название: {movie.Name}";
            label4.Text = $"Жанр: {movie.Genre}";
            label5.Text = $"Оценка: {movie.Grade}";
            label6.Text = movie.Link;
        }
    }
}
