using MovieMate.DBConnect;
using System.Text;
using System.Security.Cryptography;

namespace MovieMate.EnterForms
{
    public partial class LogInForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;

        public LogInForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            NickNameLabel.Text = nickname;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var pass = HashPassword(PasswordTextBox.Text);
            if (currentUser.PasswordHash != pass)
            {
                MessageBox.Show("Пароль неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainMenu mainmenu = new MainMenu(currentUser.Nickname);
                mainmenu.Show();
            }
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
