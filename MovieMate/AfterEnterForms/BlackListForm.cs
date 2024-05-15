using System.Data;
using MovieMate.AfterEnterForms.CompilationForm;
using MovieMate.DBConnect;
using NLog;

namespace MovieMate
{
    public partial class BlackListForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Movie selectedMovie;
        CompilationManager compilationManager;
        Compilation defaultCompilation;
        public BlackListForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
                var idBlackList = currentUser.IdBlackList;
                DisplaySimilarMovies(idBlackList);
                compilationManager = new CompilationManager(db);
                defaultCompilation = db.Compilations.FirstOrDefault(c => c.Id == 1);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при инициализации BlackListForm.");
                MessageBox.Show("Произошла ошибка при инициализации формы.");
                this.Close();
            }
        }

        private void BlackListForm_Load(object sender, EventArgs e)
        {
            try
            {
                var idBlackList = currentUser.IdBlackList;
                DisplaySimilarMovies(idBlackList);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке BlackListForm.");
                MessageBox.Show("Произошла ошибка при загрузке формы.");
            }

        }

        private void DisplaySimilarMovies(string idBlackList)
        {
            try
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
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при отображении фильмов.");
                MessageBox.Show("Произошла ошибка при отображении фильмов.");
            }
        }

        private void FavListbutton_Click(object sender, EventArgs e)
        {
            var favoritesListForm = new FavouritesListForm(UserNickname);
            favoritesListForm.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Избранное' для пользователя {UserNickname}.");
        }

        private void MainMenubutton_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Рекомендации' для пользователя {UserNickname}.");
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    BlackListDataGridView.Rows[e.RowIndex].Selected = true;

                    var selectedMovieName = BlackListDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                    var selectedMovieYear = Convert.ToInt32(BlackListDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                    selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при выборе фильма");
                MessageBox.Show("Произошла ошибка при выборе фильма.");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMovie == null)
                {
                    MessageBox.Show("Пожалуйста выберите фильм!");
                    return;
                }

                var selectedMovieId = selectedMovie.Id;
                var movieDetailsForm = new MovieCard(selectedMovieId);
                movieDetailsForm.Show();
                logger.Info($"Открытие карточки фильма {selectedMovie.Name} ({selectedMovie.Year}) пользователем {UserNickname}.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при открытии карточки фильма.");
                MessageBox.Show("Произошла ошибка при открытии карточки фильма.");
            }
        }

        private void deleteBlackList_Click(object sender, EventArgs e)
        {
            try
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
                compilationManager.AddMovieToCompilation(defaultCompilation, selectedMovie.Id, currentUser.Id);

                MessageBox.Show("Фильм удален из чёрного списка!");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при удалении фильма из черного списка");
                MessageBox.Show("Произошла ошибка при удалении фильма из черного списка.");
            }
        }

        private void generalCompilationButton_Click(object sender, EventArgs e)
        {
            var gf = new GeneralCompilationForm(UserNickname);
            gf.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Подборки' для пользователя {UserNickname}.");
        }
    }
}

