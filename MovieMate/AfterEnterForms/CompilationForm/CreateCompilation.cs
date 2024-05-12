using MovieMate.DBConnect;

namespace MovieMate.AfterEnterForms
{
    public partial class CreateCompilation : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        public CreateCompilation(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idUser = currentUser.Id;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string compilationName = NameCompTextBox.Text.Trim();

            if (string.IsNullOrEmpty(compilationName))
            {
                MessageBox.Show("Пожалуйста введите имя подборки.");
                return;
            }
            Compilation newCompilation = new Compilation
            {
                Name = compilationName,
                IdPerson = currentUser.Id.ToString() + ','
            };
            db.Compilations.Add(newCompilation);
            db.SaveChanges();
            MessageBox.Show($"Подборка '{compilationName}' успешно создана!");
        }
    }
}
