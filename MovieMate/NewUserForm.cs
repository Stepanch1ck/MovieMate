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
        private void secondEnterButton_Click(object sender, EventArgs e)
        {
            using (var context = new MovieDbContext())
            {
                var newUser = new Person { Nickname = richTextBox1.Text };
                context.People.Add(newUser);
                context.SaveChanges();

                int userId = newUser.Id;

                if (moviesCheckBox1.Checked)
                {
                    context.People.Find(userId).IdFavorites = "1";
                }
                if(moviesCheckBox2.Checked)
                {
                    context.People.Find(userId).IdFavorites = "3";
                }
                if (moviesCheckBox3.Checked)
                {
                    context.People.Find(userId).IdFavorites = "4";
                }
                if (moviesCheckBox4.Checked)
                {
                    context.People.Find(userId).IdFavorites = "2";
                }
                context.SaveChanges();
                var mainMenuForm = new MainMenu();
                mainMenuForm.Show();
                this.Close();
            }

        }
        
    }
}
