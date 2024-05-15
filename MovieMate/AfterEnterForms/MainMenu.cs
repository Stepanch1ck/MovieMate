using MovieMate.DBConnect;
using System.Data;
using MovieMate.AfterEnterForms.CompilationForm;
using NLog;

namespace MovieMate
{

    public partial class MainMenu : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Movie selectedMovie;
        CompilationManager compilationManager;
        Compilation defaultCompilation;

        public MainMenu(string nickname)
        {

            InitializeComponent();
            UserNickname = nickname;
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
                logger.Info($"Пользователь {UserNickname} авторизован.");
                var idMovieLike = currentUser.IdMovieLike;
                DisplaySimilarMovies(idMovieLike);
                secondNicknameLabel.Text = nickname;
                compilationManager = new CompilationManager(db);

                defaultCompilation = db.Compilations.FirstOrDefault(c => c.Id == 1);
                if (defaultCompilation != null && !defaultCompilation.IdPerson.Split(',').Contains(currentUser.Id.ToString())) ;
                defaultCompilation.IdPerson += "," + currentUser.Id;
                logger.Info($"Пользователь {UserNickname} добавлен в общую компиляцию.");

                if (defaultCompilation != null && !string.IsNullOrEmpty(currentUser.IdFavorites))
                {
                    foreach (var movieId in currentUser.IdFavorites.Split(',').Select(int.Parse))
                    {
                        compilationManager.AddMovieToCompilation(defaultCompilation, movieId, currentUser.Id);
                        logger.Info($"Фильм с ID {movieId} добавлен в общую компиляцию пользователя {UserNickname}.");
                    }
                }
                db.SaveChanges();
                logger.Info($"Данные пользователя {UserNickname} обновлены.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при авторизации пользователя {UserNickname}.");
                MessageBox.Show("Ошибка при авторизации. Попробуйте перезапустить приложение.");
                this.Close();
            }
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                var idMovieLike = currentUser.IdMovieLike;
                DisplaySimilarMovies(idMovieLike);
                logger.Info($"Отображение похожих фильмов для пользователя {UserNickname}.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при отображении похожих фильмов для пользователя {UserNickname}.");
                MessageBox.Show("Ошибка при отображении фильмов. Попробуйте перезапустить приложение.");
            }
        }

        public void DisplaySimilarMovies(string idMovieLike)
        {
            try
            {
                if (string.IsNullOrEmpty(idMovieLike))
                {
                    var allMovies = db.Movies.ToList();
                    filmsDataGridView.Rows.Clear();
                    foreach (var movie in allMovies)
                    {
                        filmsDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
                    }
                    logger.Info($"Отображение всех фильмов для пользователя {UserNickname}.");
                    return;

                }
                else
                {
                    List<int> movieIds = idMovieLike.Split(',').Select(int.Parse).ToList();
                    List<int> blacklistedMovieIds = new List<int>();

                    if (!string.IsNullOrEmpty(currentUser.IdBlackList))
                    {
                        blacklistedMovieIds = currentUser.IdBlackList.Split(',').Select(int.Parse).ToList();
                    }

                    var likedGenres = db.Movies
                    .Where(m => movieIds.Contains(m.Id))
                    .Select(m => m.Genre)
                    .Distinct()
                    .ToList();

                    var similarMovies = db.Movies
                        .Where(m => likedGenres.Contains(m.Genre)
                            && !movieIds.Contains(m.Id)
                            && !blacklistedMovieIds.Contains(m.Id))
                        .ToList();

                    filmsDataGridView.Rows.Clear();
                    foreach (var movie in similarMovies)
                    {
                        filmsDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
                    }
                    logger.Info($"Отображение похожих фильмов для пользователя {UserNickname}.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при отображении похожих фильмов для пользователя {UserNickname}.");
                MessageBox.Show("Ошибка при отображении фильмов. Попробуйте перезапустить приложение.");
            }
        }

        public void favoritesButton_Click(object sender, EventArgs e)
        {
            var favouritesListForm = new FavouritesListForm(UserNickname);
            favouritesListForm.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Избранное' для пользователя {UserNickname}.");
        }

        private void BlackListbutton_Click(object sender, EventArgs e)
        {
            var blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Чёрный список' для пользователя {UserNickname}.");
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    filmsDataGridView.Rows[e.RowIndex].Selected = true;

                    string selectedMovieName = filmsDataGridView.Rows[e.RowIndex].Cells["filmname"].Value.ToString();
                    int selectedMovieYear = Convert.ToInt32(filmsDataGridView.Rows[e.RowIndex].Cells["Year"].Value);

                    selectedMovie = db.Movies.FirstOrDefault(m => m.Name == selectedMovieName && m.Year == selectedMovieYear);
                    logger.Info($"Фильм {selectedMovieName} ({selectedMovieYear}) выбран пользователем {UserNickname}.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при выборе фильма пользователем {UserNickname}.");
                MessageBox.Show("Ошибка при выборе фильма. Попробуйте перезапустить приложение.");
            }
        }

        private void openButton_Click_1(object sender, EventArgs e)
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
                logger.Error(ex, $"Ошибка при открытии карточки фильма пользователем {UserNickname}.");
                MessageBox.Show("Ошибка при открытии карточки фильма. Попробуйте перезапустить приложение.");
            }
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMovie == null)
                {
                    MessageBox.Show("Выберите фильм двойным кликом!");
                    return;
                }
                if (currentUser.IdFavorites != null && currentUser.IdFavorites.Contains(selectedMovie.Id.ToString()))
                {
                    MessageBox.Show("Этот фильм уже в избранном!");
                    return;
                }
                if (currentUser.IdFavorites == null)
                {
                    currentUser.IdFavorites = selectedMovie.Id.ToString();
                }
                else
                {
                    currentUser.IdFavorites += "," + selectedMovie.Id;
                }
                db.SaveChanges();
                DisplaySimilarMovies(currentUser.IdMovieLike);
                compilationManager.AddMovieToCompilation(defaultCompilation, selectedMovie.Id, currentUser.Id);
                MessageBox.Show("Фильм добавлен в избранное!");
                logger.Info($"Фильм {selectedMovie.Name} ({selectedMovie.Year}) добавлен в избранное пользователем {UserNickname}.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при добавлении фильма в избранное пользователем {UserNickname}.");
                MessageBox.Show("Ошибка при добавлении фильма в избранное. Попробуйте перезапустить приложение.");
            }
        }

        private void addBlackListButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMovie == null)
                {
                    MessageBox.Show("Выберите фильм двойным кликом!");
                    return;
                }
                if (currentUser.IdBlackList != null && currentUser.IdBlackList.Contains(selectedMovie.Id.ToString()))
                {
                    MessageBox.Show("Этот фильм уже в чёрном списке!");
                    return;
                }
                if (currentUser.IdBlackList == null)
                {
                    currentUser.IdBlackList = selectedMovie.Id.ToString();
                }
                else
                {
                    currentUser.IdBlackList += "," + selectedMovie.Id;
                }
                db.SaveChanges();
                DisplaySimilarMovies(currentUser.IdMovieLike);

                compilationManager.CheckAndRemoveBlacklistedMovies(defaultCompilation);
                MessageBox.Show("Фильм добавлен в чёрный список!");
                logger.Info($"Фильм {selectedMovie.Name} ({selectedMovie.Year}) добавлен в чёрный список пользователем {UserNickname}.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при добавлении фильма в чёрный список пользователем {UserNickname}.");
                MessageBox.Show("Ошибка при добавлении фильма в чёрный список. Попробуйте перезапустить приложение.");
            }
        }

        private void generalCompilationButton_Click(object sender, EventArgs e)
        {
            var gf = new GeneralCompilationForm(UserNickname);
            gf.Show();
            this.Close();
            logger.Info($"Переход на страницу 'Подборки' для пользователя {UserNickname}.");
        }

        private void secondNicknameLabel_Click(object sender, EventArgs e)
        {
            var info = new UserInfo(currentUser.Nickname);
            info.Show();
            logger.Info($"Открытие страницы профиля пользователя {UserNickname}.");
        }

        private void RecomendationButton_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            this.Close();
            logger.Info($"Перезагрузка главной страницы для пользователя {UserNickname}.");
        }

        private void FavButtonMouseHover(object sender, EventArgs e)
        {
            var tooltipFavBut = new ToolTip();
            tooltipFavBut.Show("Открыть список избранного", FavoritesButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка избранного списка.");
        }

        private void MainMenuMouseHover(object sender, EventArgs e)
        {
            var tooltipMainMenu = new ToolTip();
            tooltipMainMenu.Show("Открыть список рекомендаций", RecomendationButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка списка рекомендаций");
        }

        private void BlackListMouseHover(object sender, EventArgs e)
        {
            var tooltipBlackList = new ToolTip();
            tooltipBlackList.Show("Открыть черного список", BlackLIstButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка черного списка");
        }

        private void CompilationMouseHover(object sender, EventArgs e)
        {
            var tooltipCompilationBut = new ToolTip();
            tooltipCompilationBut.Show("Открыть список подборок", CompilationButton, 0, 0, 2000);
            logger.Info($"Показывается подсказка списка подборок");
        }

        private void UserInfoMouseHover(object sender, EventArgs e)
        {
            var tooltipUserInfo = new ToolTip();
            tooltipUserInfo.Show("Открыть информацию о профиле", secondNicknameLabel, 0, 0, 2000);
            logger.Info($"Показывается подсказка информации о профиле");
        }
    }
}
