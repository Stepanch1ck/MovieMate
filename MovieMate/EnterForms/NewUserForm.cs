using MovieMate.DBConnect;
using NLog;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MovieMate
{
    public partial class NewUserForm : Form
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string selectedNickname = string.Empty;

        public NewUserForm()
        {
            InitializeComponent();
            NameTextBox.KeyDown += richTextBox1_KeyDown;
        }

        public void NewUserForm_Load(object sender, EventArgs e)
        {
            logger.Info("Загрузка формы NewUserForm.");
            try
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text))
                {
                    selectedNickname = NameTextBox.Text.ToString();
                    using (var context = new MovieDbContext())
                    {
                        var newUser = new Person { Nickname = selectedNickname };
                        context.People.Add(newUser);
                        context.SaveChanges();

                        var userId = newUser.Id;

                        if (moviesCheckBox1.Checked)
                        {
                            context.People.Find(userId).IdFavorites = "1";
                        }
                        if (moviesCheckBox2.Checked)
                        {
                            context.People.Find(userId).IdFavorites = "3";
                        }
                        if (moviesCheckBox3.Checked)
                        {
                            context.People.Find(userId).IdFavorites = "4";
                        }
                        if (moviesCheckBox4.Checked)
                        {
                            context.People.Find(userId).IdFavorites = "2";
                        }
                        logger.Info($"Создан новый пользователь с именем: {selectedNickname}.");
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при создании пользователя.");
                MessageBox.Show("Произошла ошибка при создании пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void SaveTextToDatabase(string text)
        {
            logger.Info($"Сохранение текста {text} в базу данных.");
            try
            {
                using (var context = new MovieDbContext())
                {
                    var person = new Person { Nickname = text };
                    context.People.Add(person);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при сохранении текста в базу данных.");
                MessageBox.Show("Произошла ошибка при сохранении текста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var enteredText = NameTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(enteredText))
                {
                    SaveTextToDatabase(enteredText);
                    NameTextBox.Clear();
                }
            }
        }
        private byte[] GetPictureData()
        {
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }

        private void pictureSelectButton_Click(object sender, EventArgs e)
        {
            logger.Info("Выбор изображения пользователем.");
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void loginVKLabel_Click(object sender, EventArgs e)
        {
            logger.Info("Вход через VK.");
            var loginForm = new VKLoginForm();
            loginForm.ShowDialog();
            this.Close();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка входа.");
            var password = PasswordTextBox.Text;
            var passwordRepeat = PasswordRepeatTextBox.Text;
            var idMovieLike = GetSelectedMovieIds();
            var nickname = NameTextBox.Text.Trim();
            byte[] picture = GetPictureData();
            var mail = MailTextBox.Text;

            try
            {
                if (!IsValidEmail(mail))
                {
                    logger.Warn("Введен некорректный адрес электронной почты.");
                    MessageBox.Show("Введите корректный адрес электронной почты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(nickname))
                {
                    logger.Warn("Имя пользователя не должно быть пустым.");
                    MessageBox.Show("Имя не должно быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != passwordRepeat)
                {
                    logger.Warn("Пароли не совпадают.");
                    MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidPassword(password))
                {
                    logger.Warn("Пароль не соответствует требованиям.");
                    MessageBox.Show("Пароль должен содержать минимум 8 символов, включая хотя бы одну заглавную букву, одну строчную букву и одну цифру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var hashedPassword = HashPassword(password);

                using (var context = new MovieDbContext())
                {
                    var newUser = new Person
                    {
                        Nickname = nickname,
                        IdMovieLike = idMovieLike,
                        PasswordHash = hashedPassword,
                        Picture = picture,
                        Email = mail
                    };
                    context.People.Add(newUser);
                    context.SaveChanges();
                    logger.Info($"Создан новый пользователь: {nickname}.");
                }

                var mainMenu = new MainMenu(nickname);
                mainMenu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при регистрации пользователя.");
                MessageBox.Show("Произошла ошибка при регистрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex);
        }
        private bool IsValidPassword(string password)
        {
            var passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            return Regex.IsMatch(password, passwordRegex);
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
