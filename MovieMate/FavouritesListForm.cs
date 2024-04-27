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
    public partial class FavouritesListForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
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
                MessageBox.Show("У вас ещё нет фильмов в избранном!");
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
    }
}
