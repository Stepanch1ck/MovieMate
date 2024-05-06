using System.Text;
using MovieMate.DBConnect;
using System.Security.Cryptography;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Text.RegularExpressions;

namespace MovieMate
{
    public partial class NewUserForm : Form
    {
        private const string ClientId = "463ec85cc1f64b51a8eef87d5f7c7bab";
        private const string ClientSecret = "3ea4fc2d9a794b7faad64c68f30e7255";
        private const string RedirectUri = "myapp://auth";

        private string yandexUsername;
        private byte[] yandexProfilePicture;
        private bool yandexAuthorized = false;

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
        

        private void pictureButton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void secondEnterButton_Click_1(object sender, EventArgs e)
        {
            string nickname;
            string password = PasswordTextBox.Text;
            string passwordRepeat = PasswordRepeatTextBox.Text;
            string idMovieLike = GetSelectedMovieIds(); 
            byte[] picture;
            if (yandexAuthorized)
            {
                nickname = yandexUsername;
                picture = yandexProfilePicture;
            }
            else
            {
                nickname = NameTextBox.Text.Trim();
                picture = GetPictureData();
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
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль слишком короткий, должно быть минимум 8 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Picture = picture
                };
                context.People.Add(newUser);
                context.SaveChanges();
            }


            var mainMenu = new MainMenu(nickname);
            mainMenu.Show();
            this.Close();
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
        private void yandexAuthButton_Click(object sender, EventArgs e)
        {
            string authorizeUrl = $"https://oauth.yandex.ru/authorize?response_type=code&client_id={ClientId}&redirect_uri={RedirectUri}";
            Process.Start(authorizeUrl);
        }
        private string ExtractCodeFromUrl(string url)
        {
            const string pattern = @"code=([^&]+)";
            var match = Regex.Match(url, pattern);
            return match.Success ? match.Groups[1].Value : null;
        }

        private async Task ProcessAuthResponse(string url)
        {
            string code = ExtractCodeFromUrl(url);

            var tokenResponse = await GetAccessTokenAsync(code);
            string accessToken = tokenResponse["access_token"].ToString();

            var userInfo = await GetUserInfoAsync(accessToken);
            yandexUsername = userInfo["login"].ToString();

            string pictureUrl = userInfo["default_avatar_id"].ToString();
            pictureUrl = $"https://avatars.yandex.net/get-yapic/{pictureUrl}/islands-200";
            yandexProfilePicture = await DownloadImageAsync(pictureUrl);

            NameTextBox.Text = yandexUsername;
            pictureBox1.Image = Image.FromStream(new MemoryStream(yandexProfilePicture));

            yandexAuthorized = true;
        }

        private async Task<JObject> GetAccessTokenAsync(string code)
        {
            var client = new RestClient("https://oauth.yandex.ru/token");
            var request = new RestRequest("/token",Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("code", code);
            request.AddParameter("client_id", ClientId);
            request.AddParameter("client_secret", ClientSecret);
            var response = await client.ExecuteAsync(request);
            return JObject.Parse(response.Content);
        }

        private async Task<JObject> GetUserInfoAsync(string accessToken)
        {
            var client = new RestClient("https://login.yandex.ru/info");
            var request = new RestRequest();
            request.AddHeader("Authorization", $"OAuth {accessToken}");
            var response = await client.ExecuteAsync(request);
            return JObject.Parse(response.Content);
        }
        private async Task<byte[]> DownloadImageAsync(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = await client.ExecuteAsync(request);
            return response.RawBytes;
        }

    }

}
