using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace MovieMate
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            RefreshListBox();

        }
        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }
        public void open(object obj)
        {
            Application.Run(new NewUserForm());
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
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
                    MessageBox.Show("�� ��������� ���� ������");
                    
                }
            }
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string selectedNickname = listBox1.SelectedItem.ToString();
                nickNameLabel.Text = selectedNickname;
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


    }





}
