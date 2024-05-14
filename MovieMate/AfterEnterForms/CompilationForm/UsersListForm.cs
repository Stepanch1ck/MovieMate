using MovieMate.DBConnect;
using System.Data;

namespace MovieMate
{
    public partial class UsersListForm : Form
    {

        MovieDbContext db = new MovieDbContext();

        public UsersListForm(Compilation compilation)
        {
            InitializeComponent();
            DisplaySimilarCompilation(compilation);
            menuLabel.Text=compilation.Name;
        }

        public void DisplaySimilarCompilation(Compilation compilation)
        {
            if (compilation == null || string.IsNullOrEmpty(compilation.IdMovie))
            {
                filmsDataGridView.Rows.Clear();
                return;
            }

            List<int> movieIds = compilation.IdMovie.Split(',')
                .Where(idStr => !string.IsNullOrEmpty(idStr))
                .Select(int.Parse)
                .ToList();

            var movies = db.Movies.Where(m => movieIds.Contains(m.Id)).ToList();

            filmsDataGridView.Rows.Clear();
            if (filmsDataGridView.Columns.Count == 0)
            {
                filmsDataGridView.Columns.Add("MovieName", "Movie Name");
                filmsDataGridView.Columns.Add("Year", "Year");
                filmsDataGridView.Columns.Add("Grade", "Grade");
            }

            foreach (var movie in movies)
            {
                filmsDataGridView.Rows.Add(movie.Name, movie.Year, movie.Grade);
            }
        }
    }
}
