﻿using System;
using System.Collections;
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
        Movie selectedMovie;
        public BlackListForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idBlackList = currentUser.IdBlackList;
            DisplaySimilarMovies(idBlackList);
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
                MessageBox.Show("У вас ещё нет фильмов в чёрном списке!");
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

        private void blackListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BlackListDataGridView.Rows[e.RowIndex].Selected = true;

                string selectedMovieName = BlackListDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                int selectedMovieYear = Convert.ToInt32(BlackListDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
            }
        }
        void BlackListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Получение информации о фильме из выбранной строки
            var selectedMovieId = Convert.ToInt32(BlackListDataGridView.Rows[e.RowIndex].Cells["Id"].Value);


        }
        private void deleteFromBlackListButton_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Выберите фильм двойным кликом!");
                return;
            }
            if (currentUser.IdBlackList != null && currentUser.IdBlackList.Contains(selectedMovie.Id.ToString()))
            {

                var blackListIds = currentUser.IdBlackList.Split(',');
                var updatedBlackList = new List<string>();
                foreach (var id in blackListIds)
                {
                    if (id != selectedMovie.Id.ToString())
                    {
                        updatedBlackList.Add(id);
                    }
                }
                currentUser.IdBlackList = string.Join(",", updatedBlackList);
                db.SaveChanges();
                DisplaySimilarMovies(currentUser.IdMovieLike);
                MessageBox.Show("Фильм удалён из чёрного списка!");
            }
            else
            {
                MessageBox.Show("Этот фильм не находится в чёрном списке!");
            }
        }
        private void BlackListForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FavouritesListForm favoritesListForm = new FavouritesListForm(UserNickname);
            favoritesListForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu blackListForm = new MainMenu(UserNickname);
            blackListForm.Show();
            this.Close();
        }
    }

}

