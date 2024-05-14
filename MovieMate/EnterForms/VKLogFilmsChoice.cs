using MovieMate.DBConnect;

namespace MovieMate.EnterForms
{
    public partial class VKLogFilmsChoice : Form
    {
        private readonly string vkUserId;
        public VKLogFilmsChoice(string userId)
        {
            InitializeComponent();
            vkUserId = userId;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string idMovieLike = GetSelectedMovieIds();

            using (var context = new MovieDbContext())
            {
                var user = context.People.FirstOrDefault(p => p.VkId == vkUserId.ToString());
                if (user != null)
                {
                    user.IdFavorites = idMovieLike;
                    context.SaveChanges();

                    MessageBox.Show("Фильмы успешно сохранены!");
                    MainMenu mainMenu = new MainMenu(user.Nickname);
                    mainMenu.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
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
    }
}
