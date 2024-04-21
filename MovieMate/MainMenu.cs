using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMate
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
        }

        private void russianButton_Click(object sender, EventArgs e)
        {

        }
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            languageComboBox.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
                System.Globalization.CultureInfo.GetCultureInfo("en-US")

            };
            languageComboBox.DisplayMember = "NativeName";
            languageComboBox.ValueMember = "Name";
        }
    }
}
