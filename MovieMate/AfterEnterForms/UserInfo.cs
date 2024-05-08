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
        }
    }
}
