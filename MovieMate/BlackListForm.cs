using System;
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

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BlackListDataGridView.Rows[e.RowIndex].Selected = true;

                string selectedMovieName = BlackListDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                int selectedMovieYear = Convert.ToInt32(BlackListDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
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

        private void deleteBlackList_Click(object sender, EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show("Выберите фильм для удаления из чёрного списка!");
                return;
            }
            List<int> movieIds = currentUser.IdBlackList.Split(',').Select(int.Parse).ToList();
            movieIds.Remove(selectedMovie.Id);
            currentUser.IdBlackList = string.Join(",", movieIds);
            if (currentUser.IdBlackList.StartsWith(","))
            {
                currentUser.IdBlackList = currentUser.IdBlackList.Substring(1);
            }
            db.SaveChanges();
            DisplaySimilarMovies(currentUser.IdBlackList);

            MessageBox.Show("Фильм удален из чёрного списка!");
        }

        private void generalCompilationButton_Click(object sender, EventArgs e)
        {
            GeneralCompilationForm gf = new GeneralCompilationForm();
            gf.Show();
            this.Close();
        }
    }

}

