using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMate
{
    public partial class GeneralCompilationForm : Form
    {
        public GeneralCompilationForm()
        {
            InitializeComponent();
        }

        private void openFavButton_Click(object sender, EventArgs e)
        {
            UsersListForm users = new UsersListForm();
            users.Show();
        }
    }
}
