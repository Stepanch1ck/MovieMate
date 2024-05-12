
using System.Data;
using MovieMate.AfterEnterForms;
using MovieMate.DBConnect;

namespace MovieMate
{
    public partial class GeneralCompilationForm : Form
    {
        public string UserNickname { get; set; }
        MovieDbContext db = new MovieDbContext();
        Person currentUser;
        Compilation compilation;

        public GeneralCompilationForm(string nickname)
        {
            InitializeComponent();
            UserNickname = nickname;
            currentUser = db.People.FirstOrDefault(p => p.Nickname == UserNickname);
            var idUser = currentUser.Id;
            DisplaySimilarCompilations(idUser);
        }

        private void openFavButton_Click(object sender, EventArgs e)
        {
            UsersListForm users = new UsersListForm(compilation);
            users.Show();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            var favouritesListForm = new FavouritesListForm(UserNickname);
            favouritesListForm.Show();
            this.Close();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(UserNickname);
            mainMenu.Show();
            this.Close();
        }

        private void blackListButton_Click(object sender, EventArgs e)
        {
            BlackListForm blackListForm = new BlackListForm(UserNickname);
            blackListForm.Show();
            this.Close();
        }

        private void filmsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filmsDataGridView.Rows[e.RowIndex].Selected = true;

                string selcompilation = filmsDataGridView.Rows[e.RowIndex].Cells["CompilationName"].Value.ToString();

                compilation = db.Compilations.FirstOrDefault(m => m.Name == selcompilation);
            }
        }

        void DisplaySimilarCompilations(int idUser)
        {
            if (idUser == 0)
            {
                return;
            }
            var userCompilations = db.Compilations
                .Where(c => c.IdPerson.Contains(idUser.ToString()))
                .ToList();

            if (filmsDataGridView.Columns.Count == 0)
            {
                filmsDataGridView.Columns.Add("CompilationName", "Compilation Name");
            }

            filmsDataGridView.Rows.Clear();
            foreach (var compilation in userCompilations)
            {
                filmsDataGridView.Rows.Add(compilation.Name);
            }
        }

        private void GeneralCompilationForm_Load(object sender, EventArgs e)
        {
            var idUser = currentUser.Id;
            DisplaySimilarCompilations(idUser);
        }

        private void createCompilationButton_Click(object sender, EventArgs e)
        {
            CreateCompilation createCompilation = new CreateCompilation(UserNickname);
            createCompilation.Show();

        }
        private void UserListButton_Click(Object sender, EventArgs e)
        {
           if (compilation!=null)
            {
                UsersCompilationList usercomplist = new UsersCompilationList(compilation, UserNickname);
                usercomplist.Show();
            }
            else
            {
                MessageBox.Show("Выберите подборку");
            }
            

        }

        private void MovListCompilation_Click(object sender, EventArgs e)
        {
            if (compilation!=null)
            {
                MovieListComp moviecomplist = new MovieListComp(compilation);
                moviecomplist.Show();
            }
            else
            {
                MessageBox.Show("Выберите подборку");
            }
            
        }
    }
}
