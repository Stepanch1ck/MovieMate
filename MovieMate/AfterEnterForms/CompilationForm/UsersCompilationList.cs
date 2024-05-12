using MovieMate.DBConnect;
using System.Data;

namespace MovieMate.AfterEnterForms
{

    public partial class UsersCompilationList : Form
    {
        public string selectedNickname = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;
        Person currentUser;

        public UsersCompilationList(Compilation compilation, string nickname)
        {
            InitializeComponent();
            currentCompilation = compilation;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == nickname);
            LoadUserListBox();

        }
        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserListBox.SelectedItems.Count > 0)
            {
                selectedNickname = UserListBox.SelectedItem.ToString();
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            addUser useradd = new addUser(currentCompilation);
            useradd.Show();
            this.Close();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (UserListBox.SelectedItems.Count > 0)
            {
                Person selectedPerson = (Person)UserListBox.SelectedItem;
                
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
                    int personId = int.Parse(userId);
                    Person person = db.People.Find(personId);
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

        private void LoadUserListBox()
        {
            UserListBox.Items.Clear();
            UserListBox.DisplayMember = "Nickname";

            
            string[] userIdStrings = currentCompilation.IdPerson.Split(',');

            foreach (string userIdString in userIdStrings)
            {
                if (int.TryParse(userIdString, out int userId))
                {
                    Person person = db.People.Find(userId);
                    if (person != null)
                    {
                        UserListBox.Items.Add(person);
                    }
                }
            }
        }
    }
}
