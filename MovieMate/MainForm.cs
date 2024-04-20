using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace MovieMate
{
    public partial class MainForm : Form
    {
        private MovieDbContext _dbContext;
        Thread gh;
        public MainForm()
        {
            InitializeComponent();
            _dbContext = new MovieDbContext();
        }
        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            gh = new Thread(open1);
            gh.SetApartmentState(ApartmentState.STA);
            gh.Start();
        }
        public void open1(object obj)
        {
            Application.Run(new NewUserForm());
        }

    }


    

    
}
