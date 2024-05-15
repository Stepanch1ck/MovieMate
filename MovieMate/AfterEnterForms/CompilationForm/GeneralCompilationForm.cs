
using System.Data;
using MovieMate.AfterEnterForms;
using MovieMate.DBConnect;
using System.Net;
using System.Net.Mail;
using NLog;

namespace MovieMate
{
    public partial class GeneralCompilationForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Compilation compilation;
        private string mailAddress = "moviemate@mail.ru";

        public GeneralCompilationForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
                var idUser = currentUser.Id;
                DisplaySimilarCompilations(idUser);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при получении данных пользователя");
                MessageBox.Show("Произошла ошибка при загрузке данных пользователя. Пожалуйста, обратитесь к администратору.");
            }
        }

        private void openFavButton_Click(object sender, EventArgs e)
        {
            var users = new UsersListForm(compilation);
            users.Show();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            var favouritesListForm = new FavouritesListForm(UserNickname);
            favouritesListForm.Show();
            logger.Info($"Переход на страницу 'Избранное' для пользователя {UserNickname}.");
            this.Close();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            logger.Info($"Переход на страницу 'Рекомендации' для пользователя {UserNickname}.");
            this.Close();
        }

        private void blackListButton_Click(object sender, EventArgs e)
        {
            var blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            logger.Info($"Переход на страницу 'Чёрный список' для пользователя {UserNickname}.");
            this.Close();
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    filmsDataGridView.Rows[e.RowIndex].Selected = true;
                    var selcompilation = filmsDataGridView.Rows[e.RowIndex].Cells["CompilationName"].Value.ToString();
                    compilation = db.Compilations.FirstOrDefault(m => m.Name == selcompilation);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при выборе подборки");
                MessageBox.Show("Произошла ошибка при выборе подборки.");
            }
        }

        public void DisplaySimilarCompilations(int idUser)
        {
            try
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
                    filmsDataGridView.Columns.Add("CompilationName", "Название подборки");
                }

                filmsDataGridView.Rows.Clear();
                foreach (var compilation in userCompilations)
                {
                    filmsDataGridView.Rows.Add(compilation.Name);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при отображении подборок");
                MessageBox.Show("Произошла ошибка при отображении подборок.");
            }
        }

        private void GeneralCompilationForm_Load(object sender, EventArgs e)
        {
            try
            {
                var idUser = currentUser.Id;
                DisplaySimilarCompilations(idUser);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке формы");
                MessageBox.Show("Произошла ошибка при загрузке формы.");
            }
        }

        private void createCompilationButton_Click(object sender, EventArgs e)
        {
            var createCompilation = new CreateCompilation(UserNickname);
            createCompilation.Show();
            logger.Info($"Открытие страницы 'Создание списка' для пользователя {UserNickname}.");

        }
        private void UserListButton_Click(Object sender, EventArgs e)
        {
            try
            {
                if (compilation != null)
                {
                    if (compilation.Id != 1)
                    {
                        var usercomplist = new UsersCompilationList(compilation, UserNickname);
                        usercomplist.Show();
                    }
                    else
                    {
                        MessageBox.Show("Это общая подборка, она доступна всем пользователям");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите подборку");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при открытии списка пользователей подборки");
                MessageBox.Show("Произошла ошибка при открытии списка пользователей подборки.");
            }
        }

        private void MovListCompilation_Click(object sender, EventArgs e)
        {
            try
            {
                if (compilation != null)
                {
                    if (compilation.Id != 1)
                    {
                        MovieListComp moviecomplist = new MovieListComp(compilation);
                        moviecomplist.Show();
                    }
                    else
                    {
                        MessageBox.Show("Изменение списка фильмов общей подборки происходит автоматически, вам не нужно редактировать его самому!");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите подборку");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при открытии списка фильмов подборки");
                MessageBox.Show("Произошла ошибка при открытии списка фильмов подборки.");
            }
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (compilation != null)
                {
                    var recipientEmail = currentUser.Email;
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

                    var frommailaddress = new MailAddress(mailAddress, "MovieMate");
                    var tomailadress = new MailAddress(recipientEmail);
                    var subject = $"Подборка фильмов: {compilation.Name}";
                    var body = $"Привет!\n\nВот подборка фильмов, которая может тебе понравиться:\n\n";

                    var movieIds = compilation.IdMovie.Split(',').Select(int.Parse).ToList();
                    var movies = db.Movies.Where(m => movieIds.Contains(m.Id)).ToList();
                    foreach (var movie in movies)
                    {
                        body += $"- {movie.Name} ({movie.Year})\n";
                    }

                    var mailMessage = new MailMessage(frommailaddress, tomailadress);
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    var smtp = new SmtpClient();
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
                        logger.Info("Письмо успешно отправлено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при отправке письма: {ex.Message}");
                        logger.Error(ex, "Ошибка при отправке письма");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите подборку");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при отправке письма");
                MessageBox.Show("Произошла ошибка при отправке письма. Пожалуйста, обратитесь к администратору.");
            }
        }
    }
    
}
