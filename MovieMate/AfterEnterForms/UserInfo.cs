using MovieMate.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


namespace MovieMate
{
    public partial class UserInfo : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;

        public UserInfo(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            UserNameTextBox.Text = nickname;
            EmailTextBox.Text = currentUser.Email;
            if (currentUser.Picture != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(currentUser.Picture));
            }
            else
            {

                pictureBox1.Image = null;
            }
            if (currentUser.VkId == null)
            {
                VkORnoVktextBox.Text = "Без Вконтакте";
            }
            else
            {
                VkORnoVktextBox.Text = "Выполнен вход через ВК";
            }
        }
    }
}
