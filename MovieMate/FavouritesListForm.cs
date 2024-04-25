using Microsoft.VisualBasic.Devices;
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
            DisplaySimilarMovies(currentUser.IdFavorites);
        }


        private void FavouritesListForm_Load(object sender, EventArgs e)
        {
            string idFavorites = currentUser.IdFavorites;
            DisplaySimilarMovies(idFavorites);
        }

        private void DisplaySimilarMovies(string idFavorites)
        {
            List<int> movieIds = idFavorites.Split(',').Select(int.Parse).ToList();

            if (currentUser != null && !string.IsNullOrEmpty(currentUser.IdFavorites))
            {
                var favoriteMovieIds = currentUser.IdFavorites.Split(',');

                var favoriteMovies = db.Movies.Where(m => favoriteMovieIds.Contains(m.Id.ToString())).ToList();

                FavouritesDataGridView.DataSource = favoriteMovies;


                
            }
            else
            {
                MessageBox.Show("Список пуст!");
            }
        }
    }

}
