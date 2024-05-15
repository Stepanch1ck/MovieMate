using MovieMate.DBConnect;
using MovieMate.EnterForms;
using NLog;
using System.Net;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace MovieMate
{
    public partial class VKLoginForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public VKLoginForm()
        {
            InitializeComponent();
        }
        private void VKLoginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Info("Начинаем авторизацию в VK");
                ulong appId = 51923439;

                var vkApi = new VkNet.VkApi();

                try
                {
                    vkApi.Authorize(new ApiAuthParams
                    {
                        ApplicationId = appId,
                        Login = LoginTextBox.Text,
                        Password = PasswordTextBox.Text,
                    });
                }
                catch (VkNet.Exception.VkAuthorizationException ex)
                {
                    Logger.Error(ex, "Ошибка авторизации в VK");
                    MessageBox.Show($"Ошибка авторизации: {ex.Message}");
                    return;
                }

                var user = vkApi.Users.Get(new long[] { vkApi.UserId.Value }, ProfileFields.Photo50).FirstOrDefault();

                using (var context = new MovieDbContext())
                {
                    var existingUser = context.People.FirstOrDefault(p => p.VkId == vkApi.UserId.Value.ToString());
                    if (existingUser != null)
                    {
                        Logger.Info($"Пользователь {user.FirstName} уже существует в базе данных");
                        MessageBox.Show($"Добро пожаловать, {user.FirstName}!");
                        MainMenu mainMenu = new MainMenu(user.Nickname);
                        mainMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        Logger.Info($"Создаем нового пользователя {user.FirstName}");
                        var newUser = new Person
                        {
                            Nickname = $"{user.FirstName} {user.LastName}",
                            VkId = vkApi.UserId.Value.ToString(),
                        };
                        try
                        {
                            if (!string.IsNullOrEmpty(user.Photo50.AbsoluteUri))
                            {
                                using (var webClient = new WebClient())
                                {
                                    newUser.Picture = webClient.DownloadData(user.Photo50.AbsoluteUri);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Error(ex, $"Ошибка загрузки изображения пользователя {user.FirstName}");
                            MessageBox.Show($"Ошибка загрузки изображения профиля.");
                        }
                        context.People.Add(newUser);
                        context.SaveChanges();

                        Logger.Info($"Пользователь {user.FirstName} успешно зарегистрирован");
                        MessageBox.Show($"Добро пожаловать, {user.FirstName}! Вы успешно зарегистрировались. Осталось выбрать только понравившиеся фильмы.");
                        var vKLogFilmsChoice = new VKLogFilmsChoice(newUser.VkId);
                        this.Close();
                    }
                }
            
            }
            catch (VkNet.Exception.VkAuthorizationException ex)
            {
                Logger.Error(ex.Message, "Непредвиденная ошибка во время авторизации");
                MessageBox.Show($"Произошла ошибка. Пожалуйста, попробуйте снова.");
            }
        }
    }
}
