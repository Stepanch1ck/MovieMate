using MovieMate.DBConnect;
using NLog;

namespace MovieMate.AfterEnterForms
{
    public partial class addMovie : Form
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string selectedMovie = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;

        public addMovie(Compilation compilation)
        {
            InitializeComponent();
            currentCompilation = compilation;
            try
            {
                MovieListBox.Items.Clear();
                foreach (var movie in db.Movies.ToList())
                {
                    MovieListBox.Items.Add(movie.Name);
                }
                MovieListBox.Visible = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке списка фильмов.");
                MessageBox.Show("Произошла ошибка при загрузке списка фильмов.");
            }
        }

        private void movieAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedMovie))
                {
                    var selectedmovie = db.Movies.FirstOrDefault(p => p.Name == selectedMovie);

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
                        logger.Info($"{selectedMovie} добавлен в подборку!");
                        MessageBox.Show($"{selectedMovie} добавлен в подборку!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Фильм не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при добавлении фильма в подборку.");
                MessageBox.Show("Произошла ошибка при добавлении фильма в подборку.");
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MovieListBox.SelectedItems.Count > 0)
                {
                    selectedMovie = MovieListBox.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при выборе фильма из списка.");
                MessageBox.Show("Произошла ошибка при выборе фильма из списка.");
            }
        }
    }
}
