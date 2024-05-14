using MovieMate.DBConnect;

namespace MovieMate.AfterEnterForms
{
    public partial class addUser : Form
    {
        public string selectedNickname = string.Empty;
        MovieDbContext db = new MovieDbContext();
        Compilation currentCompilation;
        public addUser(Compilation compilation)
        {
            InitializeComponent();
            currentCompilation = compilation;
            UserListBox.Items.Clear();
            foreach (var person in db.People.ToList())
            {
                UserListBox.Items.Add(person.Nickname);
            }
            UserListBox.Visible = true;

        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserListBox.SelectedItems.Count > 0)
            {
                selectedNickname = UserListBox.SelectedItem.ToString();
            }
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedNickname))
            {
                var selectedPerson = db.People.FirstOrDefault(p => p.Nickname == selectedNickname);

                if (selectedPerson != null)
                {
                    if (currentCompilation.IdPerson.Contains(selectedPerson.Id.ToString()))
                    {
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
                    MessageBox.Show($"{selectedNickname} добавлен в подборку!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.");
                }
            }
        }
    }
}
