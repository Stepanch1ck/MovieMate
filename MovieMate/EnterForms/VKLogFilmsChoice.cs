using MovieMate.DBConnect;
using NLog;

namespace MovieMate.EnterForms
{
    public partial class VKLogFilmsChoice : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly string vkUserId;

        public VKLogFilmsChoice(string userId)
        {
            InitializeComponent();
            vkUserId = userId;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            logger.Info($"Кнопка 'Продолжить' нажата. VK ID пользователя: {vkUserId}");
            try
            {
                var idMovieLike = GetSelectedMovieIds();

                using (var context = new MovieDbContext())
                {
                    var user = context.People.FirstOrDefault(p => p.VkId == vkUserId.ToString());
                    if (user != null)
                    {
                        logger.Info($"Пользователь найден. ID пользователя: {user.Id}");
                        user.IdFavorites = idMovieLike;
                        context.SaveChanges();

                        logger.Info($"Фильмы успешно сохранены для пользователя {user.Nickname}.");
                        MessageBox.Show("Фильмы успешно сохранены!");
                        var mainMenu = new MainMenu(user.Nickname);
                        mainMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        logger.Warn($"Пользователь с VK ID {vkUserId} не найден.");
                        MessageBox.Show("Пользователь не найден!");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при сохранении фильмов для пользователя с VK ID {vkUserId}.");
                MessageBox.Show("Произошла ошибка при сохранении фильмов. Пожалуйста, попробуйте позже.");
            }
        }
        private string GetSelectedMovieIds()
        {
            logger.Info("Получение списка выбранных фильмов.");
            List<string> selectedIds = new List<string>();
            if (moviesCheckBox1.Checked) selectedIds.Add("1");
            if (moviesCheckBox2.Checked) selectedIds.Add("2");
            if (moviesCheckBox3.Checked) selectedIds.Add("3");
            if (moviesCheckBox4.Checked) selectedIds.Add("4");
            logger.Info($"Список выбранных фильмов: {string.Join(",", selectedIds)}");
            return string.Join(",", selectedIds);
        }
    }
}
