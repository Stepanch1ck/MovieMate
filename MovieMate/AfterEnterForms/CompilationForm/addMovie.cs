using MovieMate.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMate.AfterEnterForms
{
    public partial class addMovie : Form
    {
        public string selectedMovie = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;

        public addMovie(Compilation compilation)
        {
            InitializeComponent();
            currentCompilation = compilation;
            MovieListBox.Items.Clear();
            foreach (var movie in db.Movies.ToList())
            {
                MovieListBox.Items.Add(movie.Name);
            }
            MovieListBox.Visible = true;
        }

        private void movieAddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMovie))
            {
                Movie selectedmovie = db.Movies.FirstOrDefault(p => p.Name == selectedMovie);

                if (selectedmovie != null)
                {
                    if (currentCompilation.IdMovie.Contains(selectedmovie.Id.ToString()))
                    {
                        MessageBox.Show("Этот фильм уже есть в подборке");
                        return;
                    }
                    if (string.IsNullOrEmpty(currentCompilation.IdMovie))
                    {
                        currentCompilation.IdMovie = selectedmovie.Id.ToString();
                    }
                    else
                    {
                        currentCompilation.IdMovie += "," + selectedmovie.Id;
                    }

                    db.SaveChanges();
                    MessageBox.Show($"{selectedMovie} добавлен в подборку!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Фильм не найден.");
                }
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedItems.Count > 0)
            {
                selectedMovie = MovieListBox.SelectedItem.ToString();
            }
        }
    }
}
