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
    public partial class NewUserForm : Form
    {
        Thread th;
        public NewUserForm()
        {
            InitializeComponent();
            richTextBox1.KeyDown += richTextBox1_KeyDown;
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void secondEnterButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new MainMenu());
        }
        private void SaveTextToDatabase(string text)
        {
            
            using (var context = new MovieDbContext())
            {
                var person = new Person { Nickname = text };
                context.People.Add(person);
                context.SaveChanges();
            }
        }
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredText = richTextBox1.Text.Trim(); 
                if (!string.IsNullOrEmpty(enteredText))
                {
                    SaveTextToDatabase(enteredText); 
                    richTextBox1.Clear(); 
                }
            }
        }
    }
}
