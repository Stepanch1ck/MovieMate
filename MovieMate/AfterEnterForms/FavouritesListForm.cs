using System.Data;
using Microsoft.Extensions.Logging;
using MovieMate.AfterEnterForms.CompilationForm;
using MovieMate.DBConnect;
using NLog;

namespace MovieMate
{
    public partial class FavouritesListForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Movie selectedMovie;
        CompilationManager compilationManager;
        Compilation defaultCompilation;

        public FavouritesListForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
                if (currentUser == null)
                {
                    logger.Error($"Пользователь с никнеймом {UserNickname} не найден.");
                    MessageBox.Show("Пользователь не найден.");
                    return;
                }

                var idFavorites = currentUser.IdFavorites;
                DisplaySimilarMovies(idFavorites);
                compilationManager = new CompilationManager(db);
                defaultCompilation = db.Compilations.FirstOrDefault(c => c.Id == 1);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при инициализации FavouritesListForm.");
                MessageBox.Show("Произошла ошибка при инициализации формы.");
            }
        }

        private void FavouritesListForm_Load(object sender, EventArgs e)
        {
            try
            {
                var idFavorites = currentUser.IdFavorites;
                DisplaySimilarMovies(idFavorites);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке формы FavouritesListForm.");
                MessageBox.Show("Произошла ошибка при загрузке формы.");
            }
        }

        private void DisplaySimilarMovies(string idFavorites)
        {
            try
            {
                if (string.IsNullOrEmpty(idFavorites))
                {
                    FavouritesDataGridView.Rows.Clear();
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
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при отображении фильмов.");
                MessageBox.Show("Произошла ошибка при отображении фильмов.");
            }
        }


        private void blackListButton_Click(object sender, EventArgs e)
        {
            var blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Чёрный список' для пользователя {UserNickname}.");
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
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
                    FavouritesDataGridView.Rows[e.RowIndex].Selected = true;

                    var selectedMovieName = FavouritesDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                    var selectedMovieYear = Convert.ToInt32(FavouritesDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                    selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при выборе фильма.");
                MessageBox.Show("Произошла ошибка при выборе фильма.");
            }
        }


        private void openFavButton_Click(object sender, EventArgs e)
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

        private void deleteFavButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMovie == null)
                {
                    MessageBox.Show("Выберите фильм для удаления из избранного!");
                    return;
                }
                List<int> movieIds = currentUser.IdFavorites.Split(',').Select(int.Parse).ToList();
                movieIds.Remove(selectedMovie.Id);
                currentUser.IdFavorites = string.Join(",", movieIds);
                if (currentUser.IdFavorites.StartsWith(","))
                {
                    currentUser.IdFavorites = currentUser.IdFavorites.Substring(1);
                }
                db.SaveChanges();
                DisplaySimilarMovies(currentUser.IdFavorites);
                compilationManager.CheckAndRemoveFromCompilationIfNotInFavorites(defaultCompilation,selectedMovie.Id, currentUser.Id);

                MessageBox.Show("Фильм удален из избранного!");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при удалении фильма из избранного.");
                MessageBox.Show("Произошла ошибка при удалении фильма из избранного.");
            }
        }

        private void GenCompbutton_Click(object sender, EventArgs e)
        {
            var gf = new GeneralCompilationForm(UserNickname);
            gf.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Подборки' для пользователя {UserNickname}.");
        }
        private void FavButtonMouseHover(object sender, EventArgs e)
        {
            var tooltipFavBut = new ToolTip();
            tooltipFavBut.Show("Открыть список избранного", FavButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка избранного списка.");
        }

        private void MainMenuMouseHover(object sender, EventArgs e)
        {
            var tooltipMainMenu = new ToolTip();
            tooltipMainMenu.Show("Открыть список рекомендаций", mainMenuButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка списка рекомендаций");
        }

        private void BlackListMouseHover(object sender, EventArgs e)
        {
            var tooltipBlackList = new ToolTip();
            tooltipBlackList.Show("Открыть черного список", blackListButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка черного списка");
        }

        private void CompilationMouseHover(object sender, EventArgs e)
        {
            var tooltipCompilationBut = new ToolTip();
            tooltipCompilationBut.Show("Открыть список подборок", generalCompilationButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка списка подборок");
        }
    }
}
