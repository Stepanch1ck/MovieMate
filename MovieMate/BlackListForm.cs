﻿using System;
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
    public partial class BlackListForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        public BlackListForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            string idFavorites = currentUser.IdFavorites;
            DisplaySimilarMovies(idFavorites);
        }

        private void FavouritesListForm_Load(object sender, EventArgs e)
        {
            string idFavorites = currentUser.IdFavorites;
            DisplaySimilarMovies(idFavorites);
        }
        private void DisplaySimilarMovies(string idFavorites)
        {
            List<int> movieIds = idFavorites.Split(',').Select(int.Parse).ToList();


            var likedGenres = db.Movies
                .Where(m => movieIds.Contains(m.Id))
                .Select(m => m.Genre)
                .Distinct()
                .ToList();

            var similarMovies = db.Movies
                .Where(m => likedGenres.Contains(m.Genre) && !movieIds.Contains(m.Id))
                .ToList();

            BlackListDataGridView.Rows.Clear();
            foreach (var movie in similarMovies)
            {
                BlackListDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
            }
        }
    }
}
