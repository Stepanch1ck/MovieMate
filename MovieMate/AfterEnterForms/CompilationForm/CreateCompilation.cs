using MovieMate.DBConnect;
using NLog;

namespace MovieMate.AfterEnterForms
{
    public partial class CreateCompilation : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        public CreateCompilation(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
                var idUser = currentUser.Id;
                logger.Info($"Пользователь {UserNickname} ({currentUser.Id}) вошел в форму создания подборки.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при получении информации о пользователе.");
                MessageBox.Show("Произошла ошибка при получении информации о пользователе.");
                this.Close();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var compilationName = NameCompTextBox.Text.Trim();

            if (string.IsNullOrEmpty(compilationName))
            {
                MessageBox.Show("Пожалуйста введите имя подборки.");
                return;
            }
            try
            {
                var newCompilation = new Compilation
                {
                    Name = compilationName,
                    IdPerson = currentUser.Id.ToString() + ','
                };
                db.Compilations.Add(newCompilation);
                db.SaveChanges();
                logger.Info($"Пользователь {UserNickname} создал подборку '{compilationName}'.");
                MessageBox.Show($"Подборка '{compilationName}' успешно создана!");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при создании подборки.");
                MessageBox.Show("Произошла ошибка при создании подборки. Пожалуйста, попробуйте позже.");
            }
        }
    }
}
