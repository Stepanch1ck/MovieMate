using MovieMate.DBConnect;
using NLog;

namespace MovieMate.AfterEnterForms
{

    public partial class UsersCompilationList : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string selectedNickname = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;
        Person currentUser;

        public UsersCompilationList(Compilation compilation, string nickname)
        {
            InitializeComponent();
            currentCompilation = compilation;
            try
            {
                currentUser = db.People.FirstOrDefault(p => p.Nickname == nickname);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при получении данных о пользователе.");
                MessageBox.Show("Ошибка при получении данных о пользователе.");
                return;
            }
            LoadUserListBox();
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

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var useradd = new addUser(currentCompilation);
            useradd.Show();
            this.Close();
            logger.Info($"Открытие формы добавления пользователя в {currentCompilation.Name}.");
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserListBox.SelectedItems.Count > 0)
                {
                    var selectedPerson = (Person)UserListBox.SelectedItem;

                    if (selectedPerson.Id == currentUser.Id)
                    {
                        MessageBox.Show("Вы не можете удалить себя.");
                        return;
                    }
                    List<int> userIds = new List<int>();
                    string[] userIdStrings = currentCompilation.IdPerson.Split(',');
                    foreach (string userIdString in userIdStrings)
                    {
                        if (int.TryParse(userIdString, out int userId))
                        {
                            userIds.Add(userId);
                        }
                    }
                    userIds.Remove(selectedPerson.Id);
                    currentCompilation.IdPerson = string.Join(",", userIds);

                    UserListBox.Items.Clear();
                    foreach (var userId in currentCompilation.IdPerson.Split(','))
                    {
                        var personId = int.Parse(userId);
                        var person = db.People.Find(personId);
                        if (person != null)
                        {
                            UserListBox.Items.Add(person);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите пользователя.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при удалении пользователя из подборки.");
                MessageBox.Show("Ошибка при удалении пользователя.");
            }
        }

        private void LoadUserListBox()
        {
            try
            {
                UserListBox.Items.Clear();
                UserListBox.DisplayMember = "Nickname";

                string[] userIdStrings = currentCompilation.IdPerson.Split(',');

                foreach (string userIdString in userIdStrings)
                {
                    if (int.TryParse(userIdString, out int userId))
                    {
                        var person = db.People.Find(userId);
                        if (person != null)
                        {
                            UserListBox.Items.Add(person);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка при загрузке списка пользователей.");
                MessageBox.Show("Ошибка при загрузке списка пользователей.");
            }
        }
    }
}
