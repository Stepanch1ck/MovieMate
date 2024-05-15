using MovieMate.DBConnect;
using NLog;

namespace MovieMate.AfterEnterForms
{
    public partial class addUser : Form
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string selectedNickname = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;

        public addUser(Compilation compilation)
        {
            InitializeComponent();
            currentCompilation = compilation;
            try
            {
                logger.Info("Загрузка пользователей для добавления в подборку");
                UserListBox.Items.Clear();
                foreach (var person in db.People.ToList())
                {
                    UserListBox.Items.Add(person.Nickname);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке пользователей");
                MessageBox.Show("Ошибка при загрузке пользователей. Пожалуйста, попробуйте позже.");
                return;
            }
            UserListBox.Visible = true;
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (UserListBox.SelectedItems.Count > 0)
                {
                    selectedNickname = UserListBox.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при выборе пользователя.");
                MessageBox.Show("Произошла ошибка при выборе пользователя.");
            }
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("Добавление пользователя в подборку");
                if (!string.IsNullOrEmpty(selectedNickname))
                {
                    var selectedPerson = db.People.FirstOrDefault(p => p.Nickname == selectedNickname);
                    if (selectedPerson != null)
                    {
                        if (currentCompilation.IdPerson.Contains(selectedPerson.Id.ToString()))
                        {
                            logger.Warn("Пользователь уже есть в подборке");
                            MessageBox.Show("Этот пользователь уже есть в подборке");
                            return;
                        }

                        if (string.IsNullOrEmpty(currentCompilation.IdPerson))
                        {
                            currentCompilation.IdPerson = selectedPerson.Id.ToString();
                        }
                        else
                        {
                            currentCompilation.IdPerson += "," + selectedPerson.Id;
                        }

                        db.SaveChanges();
                        logger.Info($"Пользователь {selectedNickname} добавлен в подборку");
                        MessageBox.Show($"{selectedNickname} добавлен в подборку!");
                        this.Close();
                    }
                    else
                    {
                        logger.Warn("Пользователь не найден");
                        MessageBox.Show("Пользователь не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при добавлении пользователя в подборку");
                MessageBox.Show("Ошибка при добавлении пользователя. Пожалуйста, попробуйте позже.");
            }
        }
    }
}
