
using System.Data;
using MovieMate.AfterEnterForms;
using MovieMate.DBConnect;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Http;

namespace MovieMate
{
    public partial class GeneralCompilationForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Compilation compilation;

        public GeneralCompilationForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idUser = currentUser.Id;
            DisplaySimilarCompilations(idUser);
        }

        private void openFavButton_Click(object sender, EventArgs e)
        {
            UsersListForm users = new UsersListForm(compilation);
            users.Show();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            var favouritesListForm = new FavouritesListForm(UserNickname);
            favouritesListForm.Show();
            this.Close();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            this.Close();
        }

        private void blackListButton_Click(object sender, EventArgs e)
        {
            BlackListForm blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filmsDataGridView.Rows[e.RowIndex].Selected = true;

                string selcompilation = filmsDataGridView.Rows[e.RowIndex].Cells["CompilationName"].Value.ToString();

                compilation = db.Compilations.FirstOrDefault(m => m.Name == selcompilation);
            }
        }

        void DisplaySimilarCompilations(int idUser)
        {
            if (idUser == 0)
            {
                return;
            }
            var userCompilations = db.Compilations
                .Where(c => c.IdPerson.Contains(idUser.ToString()))
                .ToList();

            if (filmsDataGridView.Columns.Count == 0)
            {
                filmsDataGridView.Columns.Add("CompilationName", "Compilation Name");
            }

            filmsDataGridView.Rows.Clear();
            foreach (var compilation in userCompilations)
            {
                filmsDataGridView.Rows.Add(compilation.Name);
            }
        }

        private void GeneralCompilationForm_Load(object sender, EventArgs e)
        {
            var idUser = currentUser.Id;
            DisplaySimilarCompilations(idUser);
        }

        private void createCompilationButton_Click(object sender, EventArgs e)
        {
            CreateCompilation createCompilation = new CreateCompilation(UserNickname);
            createCompilation.Show();

        }
        private void UserListButton_Click(Object sender, EventArgs e)
        {
            if (compilation != null)
            {
                UsersCompilationList usercomplist = new UsersCompilationList(compilation, UserNickname);
                usercomplist.Show();
            }
            else
            {
                MessageBox.Show("Выберите подборку");
            }


        }

        private void MovListCompilation_Click(object sender, EventArgs e)
        {
            if (compilation != null)
            {
                MovieListComp moviecomplist = new MovieListComp(compilation);
                moviecomplist.Show();
            }
            else
            {
                MessageBox.Show("Выберите подборку");
            }

        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            if (compilation != null)
            {
                string recipientEmail = currentUser.Email;
                if (string.IsNullOrEmpty(recipientEmail))
                {
                    MessageBox.Show("У пользователя не указан адрес электронной почты.");
                    return;
                }
                if (compilation.IdMovie == null) 
                {
                    MessageBox.Show("В подборке нет фильмов, которые можно отправить");
                    return;
                }
                string mailAddress = "moviemate@mail.ru";
                MailAddress frommailaddress = new MailAddress(mailAddress, "MovieMate");
                MailAddress tomailadress = new MailAddress(recipientEmail);

                string subject = $"Подборка фильмов: {compilation.Name}";
                string body = $"Привет!\n\nВот подборка фильмов, которая может тебе понравиться:\n\n";
                
                var movieIds = compilation.IdMovie.Split(',').Select(int.Parse).ToList();


                var movies = db.Movies.Where(m => movieIds.Contains(m.Id)).ToList();

                foreach (var movie in movies)
                {
                    body += $"- {movie.Name} ({movie.Year})\n";
                }

                MailMessage mailMessage = new MailMessage(frommailaddress, tomailadress);
                mailMessage.Subject = subject;  
                mailMessage.Body = body;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.mail.ru";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(frommailaddress.Address, "G6ugiixj1UrrkrX5Mrjg");
                try
                {
                    smtp.Send(mailMessage);
                    MessageBox.Show("Письмо успешно отправлено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при отправке письма: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите подборку");
            }
        }
    }
    
}
