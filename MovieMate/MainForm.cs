using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace MovieMate
{
    public partial class MainForm : Form
    {

        Thread gh;
        Thread th;
        public MainForm()
        {
            InitializeComponent();

        }
        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
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
                var nicknames = context.People.Select(p => p.Nickname).ToList();

                // Установите свойство DisplayMember для ListBox
                listBox1.DisplayMember = "nickname"; // Замените на имя поля в вашем классе Person

                listBox1.DataSource = nicknames;
            }
        }

        
    }





}
