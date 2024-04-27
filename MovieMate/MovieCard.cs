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
        private readonly Movie _movie;
        private readonly int selectedMovieId;
        private Movie selectedMovie;

        public class Movie
        {
            public string Name { get; set; } 

            public string? Link { get; set; }
            public double? Grade { get; set; }
            public string? Genre { get; set; }

            public byte[] Picture { get; set; }
        }
        public MovieCard(Movie movie)
        {
            InitializeComponent();
            movie = _movie;
            LoadMovieDetails();
        }

        private void LoadMovieDetails()
        {
            label8.Text = $"Название: {_movie.Name}";
            label4.Text = $"Жанр: {_movie.Genre}";
            label5.Text = $"Оценка: {_movie.Grade}";
            label6.Text = _movie.Link;

            if (_movie.Picture != null)
            {
                moviePictureBox.Image = Image.FromStream(new MemoryStream(_movie.Picture));

            }
        }

    }
}
