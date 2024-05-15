using MovieMate.DBConnect;
using System.Text;
using System.Security.Cryptography;
using NLog;

namespace MovieMate.EnterForms
{
    public partial class LogInForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;

        public LogInForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            
            NickNameLabel.Text = nickname;
            logger.Info($"Запускается форма входа. Никнейм: {UserNickname}");
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при получении данных пользователя: {UserNickname}");
                MessageBox.Show("Ошибка получения данных пользователя. Пожалуйста, попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var pass = HashPassword(PasswordTextBox.Text);
            try
            {
                if (currentUser.PasswordHash != pass)
                {
                    MessageBox.Show("Пароль неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неверный пароль для пользователя {UserNickname}");
                }
                else
                {
                    logger.Info($"Успешный вход пользователя {UserNickname}");
                    var mainmenu = new MainMenu(currentUser.Nickname);
                    mainmenu.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Ошибка при проверке пароля пользователя: {UserNickname}");
                MessageBox.Show("Ошибка проверки пароля. Пожалуйста, попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                try
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                    var builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, $"Ошибка при хешировании пароля.");
                    MessageBox.Show("Ошибка хеширования пароля. Пожалуйста, попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
                
            }
        }
    }
}
