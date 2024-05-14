using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Windows.Forms;
using MovieMate.DBConnect;
using MovieMate.EnterForms;
using VkNet;

namespace MovieMate
{
    public partial class MainForm : Form
    {
        public string selectedNickname = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            RefreshListBox();

        }



        private void Form_Load(object sender, EventArgs e)
        {
            using (var context = new MovieDbContext())
            {

                if (context.Database.CanConnect())
                {
                    var nicknames = context.People.Select(p => p.Nickname).ToList();
                    listBox1.DisplayMember = "Nickname";
                    listBox1.DataSource = nicknames;
                    RefreshListBox();
                }
                else
                {
                    MessageBox.Show("Не подключена база данных");

                }
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                selectedNickname = listBox1.SelectedItem.ToString();
                nickNameLabel.Text = selectedNickname;
                using (var context = new MovieDbContext())
                {
                    var selectedUser = context.People.FirstOrDefault(p => p.Nickname == selectedNickname);
                    if (selectedUser != null && selectedUser.Picture != null)
                    {
                        pictureBox1.Image = Image.FromStream(new MemoryStream(selectedUser.Picture));
                    }
                    else
                    {

                        pictureBox1.Image = null;
                    }
                }
            }
        }
        private void RefreshListBox()
        {
            using (var context = new MovieDbContext())
            {
                var nicknames = context.People.Select(p => p.Nickname).ToList();
                listBox1.DataSource = null;
                listBox1.DataSource = nicknames;
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedNickname = listBox1.SelectedItem.ToString();

                using (var context = new MovieDbContext())
                {
                    var user = context.People.FirstOrDefault(p => p.Nickname == selectedNickname);

                    if (user != null && !string.IsNullOrEmpty(user.VkId))
                    {
                        VKLoginForm vkLoginForm = new VKLoginForm();
                        vkLoginForm.Show();
                    }
                    else
                    {
                        LogInForm logIn = new LogInForm(selectedNickname);
                        logIn.Show();
                    }
                }
            }
        }

        private void russianButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
        }
    }
}
