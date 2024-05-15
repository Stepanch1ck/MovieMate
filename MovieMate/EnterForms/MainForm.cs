using MovieMate.DBConnect;
using MovieMate.EnterForms;
using NLog;

namespace MovieMate
{
    public partial class MainForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public string selectedNickname = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            UserListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            RefreshListBox();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            logger.Info("�������� ����� MainForm.");
            try
            {
                using (var context = new MovieDbContext())
                {

                    if (context.Database.CanConnect())
                    {
                        var nicknames = context.People.Select(p => p.Nickname).ToList();
                        UserListBox.DisplayMember = "Nickname";
                        UserListBox.DataSource = nicknames;
                        RefreshListBox();
                        logger.Info("�������� ����������� � ���� ������.");
                    }
                    else
                    {
                        MessageBox.Show("�� ���������� ���� ������");
                        logger.Error("������ ����������� � ���� ������.");

                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "������ ��� �������� �����.");
                MessageBox.Show("��������� ������ ��� �������� �����.");
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (UserListBox.SelectedItems.Count > 0)
                {
                    selectedNickname = UserListBox.SelectedItem.ToString();
                    nickNameLabel.Text = selectedNickname;
                    using (var context = new MovieDbContext())
                    {
                        var selectedUser = context.People.FirstOrDefault(p => p.Nickname == selectedNickname);
                        if (selectedUser != null && selectedUser.Picture != null)
                        {
                            pictureBox1.Image = Image.FromStream(new MemoryStream(selectedUser.Picture));
                        }
                        else
                        {

                            pictureBox1.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "������ ��� ������ ������������.");
                MessageBox.Show("��������� ������ ��� ������ ������������.");
            }
        }
        private void RefreshListBox()
        {
            logger.Info("���������� ������ �������������.");
            try
            {
                using (var context = new MovieDbContext())
                {
                    var nicknames = context.People.Select(p => p.Nickname).ToList();
                    UserListBox.DataSource = null;
                    UserListBox.DataSource = nicknames;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "������ ��� ���������� ������ �������������.");
                MessageBox.Show("��������� ������ ��� ���������� ������ �������������.");
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            logger.Info("������ '����� ������������' ������.");
            var newUserForm = new NewUserForm();
            newUserForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserListBox.SelectedItem != null)
                {
                    selectedNickname = UserListBox.SelectedItem.ToString();

                    using (var context = new MovieDbContext())
                    {
                        var user = context.People.FirstOrDefault(p => p.Nickname == selectedNickname);

                        if (user != null && !string.IsNullOrEmpty(user.VkId))
                        {
                            var vkLoginForm = new VKLoginForm();
                            vkLoginForm.Show();
                            logger.Info($"������������ {selectedNickname} ������������ ����� VK.");
                        }
                        else
                        {
                            var logIn = new LogInForm(selectedNickname);
                            logIn.Show();
                            logger.Info($"������������ {selectedNickname} ������������ ������������ ��������.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "������ ��� ����������� ������������.");
                MessageBox.Show("��������� ������ ��� ����������� ������������.");
            }
        }

        private void russianButton_Click(object sender, EventArgs e)
        {
            logger.Info("����� �������� �����.");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            logger.Info("����� ����������� �����.");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
        }
    }
}
