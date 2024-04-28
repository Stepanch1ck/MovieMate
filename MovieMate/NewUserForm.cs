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
        public string selectedNickname = string.Empty;
        public NewUserForm()
        {
            InitializeComponent();
            richTextBox1.KeyDown += richTextBox1_KeyDown;
        }

        void NewUserForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                selectedNickname = richTextBox1.Text.ToString();
                using (var context = new MovieDbContext())
                {
                    var newUser = new Person { Nickname = selectedNickname };
                    context.People.Add(newUser);
                    context.SaveChanges();

                    var userId = newUser.Id;

                    if (moviesCheckBox1.Checked)
                    {
                        context.People.Find(userId).IdFavorites = "1";
                    }
                    if (moviesCheckBox2.Checked)
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
                }

            }

        }


        private string GetSelectedMovieIds()
        {
            List<string> selectedIds = new List<string>();
            if (moviesCheckBox1.Checked) selectedIds.Add("1");
            if (moviesCheckBox2.Checked) selectedIds.Add("2");
            if (moviesCheckBox3.Checked) selectedIds.Add("3");
            if (moviesCheckBox4.Checked) selectedIds.Add("4");
            return string.Join(",", selectedIds);
        }
        void SaveTextToDatabase(string text)
        {

            using (var context = new MovieDbContext())
            {
                var person = new Person { Nickname = text };
                context.People.Add(person);
                context.SaveChanges();
            }
        }
        void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var enteredText = richTextBox1.Text.Trim();
                if (!string.IsNullOrEmpty(enteredText))
                {
                    SaveTextToDatabase(enteredText);
                    richTextBox1.Clear();
                }
            }
        }
        private byte[] GetPictureData()
        {
            if (pictureBox1.Image != null) 
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return null; 
            }
        }
        

        private void pictureButton_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void secondEnterButton_Click_1(object sender, EventArgs e)
        {
            string nickname = richTextBox1.Text.Trim();
            string idMovieLike = GetSelectedMovieIds(); 
            byte[] picture = GetPictureData(); 


            using (var context = new MovieDbContext())
            {
                var newUser = new Person
                {
                    Nickname = nickname,
                    IdMovieLike = idMovieLike,
                    Picture = picture
                };
                context.People.Add(newUser);
                context.SaveChanges();
            }


            var mainMenu = new MainMenu(nickname);
            mainMenu.Show();
            this.Close();
        }
    }
}
