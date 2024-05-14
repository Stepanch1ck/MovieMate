using MovieMate.DBConnect;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MovieMate
{
    public partial class NewUserForm : Form
    {
        public string selectedNickname = string.Empty;
        public NewUserForm()
        {
            InitializeComponent();
            NameTextBox.KeyDown += richTextBox1_KeyDown;
        }

        void NewUserForm_Load(object sender, EventArgs e)
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
                    context.SaveChanges();
                }

            }

        }


        private string GetSelectedMovieIds()
        {
            List<string> selectedIds = new List<string>();
            if (moviesCheckBox1.Checked) selectedIds.Add("1");
            if (moviesCheckBox2.Checked) selectedIds.Add("2");
            if (moviesCheckBox3.Checked) selectedIds.Add("3");
            if (moviesCheckBox4.Checked) selectedIds.Add("4");
            return string.Join(",", selectedIds);
        }
        void SaveTextToDatabase(string text)
        {

            using (var context = new MovieDbContext())
            {
                var person = new Person { Nickname = text };
                context.People.Add(person);
                context.SaveChanges();
            }
        }
        void richTextBox1_KeyDown(object sender, KeyEventArgs e)
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
            VKLoginForm loginForm = new VKLoginForm();
            loginForm.ShowDialog();
            this.Close();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            string password = PasswordTextBox.Text;
            string passwordRepeat = PasswordRepeatTextBox.Text;
            string idMovieLike = GetSelectedMovieIds();
            string nickname = NameTextBox.Text.Trim();
            byte[] picture = GetPictureData();
            string mail = MailTextBox.Text;

            if (!IsValidEmail(mail))
            {
                MessageBox.Show("Введите корректный адрес электронной почты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("Имя не должно быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != passwordRepeat)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов, включая хотя бы одну заглавную букву, одну строчную букву и одну цифру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(password);

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
            }


            var mainMenu = new MainMenu(nickname);
            mainMenu.Show();
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex);
        }
        private bool IsValidPassword(string password)
        {
            string passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            return Regex.IsMatch(password, passwordRegex);
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
