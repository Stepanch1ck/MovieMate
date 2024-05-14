using MovieMate.DBConnect;
using MovieMate.EnterForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace MovieMate
{
    public partial class VKLoginForm : Form
    {
        public VKLoginForm()
        {
            InitializeComponent();
        }

        

        private void VKLoginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ulong appId = 51923439;

                var vkApi = new VkNet.VkApi();

                vkApi.Authorize(new ApiAuthParams
                {
                    ApplicationId = appId,
                    Login = LoginTextBox.Text,
                    Password = PasswordTextBox.Text,
                });

                string accessToken = vkApi.Token;

                var user = vkApi.Users.Get(new long[] { vkApi.UserId.Value }, ProfileFields.Photo50).FirstOrDefault();

                using (var context = new MovieDbContext())
                {
                    var existingUser = context.People.FirstOrDefault(p => p.VkId == vkApi.UserId.Value.ToString());
                    if (existingUser != null)
                    {
                        
                        MessageBox.Show($"Добро пожаловать, {user.FirstName}!");
                        MainMenu mainMenu = new MainMenu(user.Nickname);
                        mainMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        var newUser = new Person
                        {
                            Nickname = $"{user.FirstName} {user.LastName}",
                            VkId = vkApi.UserId.Value.ToString(),
                        };
                        context.People.Add(newUser);
                        context.SaveChanges();

                        MessageBox.Show($"Добро пожаловать, {user.FirstName}! Вы успешно зарегистрировались. Осталось выбрать только понравившиеся фильмы.");
                        VKLogFilmsChoice vKLogFilmsChoice = new VKLogFilmsChoice(existingUser.VkId);
                        this.Close();
                    }
                }
            
            }
            catch (VkNet.Exception.VkAuthorizationException ex)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
            }
        }
    }
}
