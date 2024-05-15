using MovieMate.DBConnect;
using NLog;

namespace MovieMate
{
    public partial class UserInfo : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;

        public UserInfo(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            try
            {
                logger.Info($"Загрузка информации о пользователе {UserNickname}");
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
                if (currentUser != null)
                {
                    logger.Info($"Информация о пользователе найдена");
                    UserNameTextBox.Text = nickname;
                    EmailTextBox.Text = currentUser.Email;
                    if (currentUser.Picture != null)
                    {
                        logger.Info($"Загрузка изображения профиля");
                        pictureBox1.Image = Image.FromStream(new MemoryStream(currentUser.Picture));
                    }
                    else
                    {
                        logger.Info($"Изображение профиля отсутствует");
                        pictureBox1.Image = null;
                    }

                    if (currentUser.VkId == null)
                    {
                        logger.Info($"Пользователь не вошёл через Вконтакте");
                        VkORnoVktextBox.Text = "Без Вконтакте";
                    }
                    else
                    {
                        logger.Info($"Пользователь вошёл через Вконтакте");
                        VkORnoVktextBox.Text = "Выполнен вход через ВК";
                    }
                }
                else
                {
                    logger.Error($"Информация о пользователе {UserNickname} не найдена");
                    MessageBox.Show($"Пользователь {UserNickname} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при загрузке информации о пользователе {UserNickname}");
                MessageBox.Show($"Произошла ошибка при загрузке информации о пользователе {UserNickname}.\n" +
                    $"Пожалуйста, попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
