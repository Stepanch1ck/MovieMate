using Xunit;
using MovieMate;
namespace MovieMateTest
{
    public class UnitTest1
    {
        MainForm m = new MainForm();
        addMovie d = new addMovie();
        addUser u = new addUser();
        CreateCompilation r = new CreateCompilation();
        [Fact]
        public void RussianLocalizationTest()
        {
            var b = new System.Globalization.CultureInfo("ru");
            var c = m.russianButton_Click();
            Assert.Equal(b, c);
        }
        [Fact]
        public void EnglishLocalizationTest()
        {
            var b = new System.Globalization.CultureInfo("en");
            var c = m.englishButton_Click();
            Assert.Equal(b, c);
        }
        [Fact]
        public void AddMovieTest()
        {
            var a = db.Movies.FirstOrDefault(p => p.Name == a);
            var b = currentCompilation.IdMovie += "," + a.Id;
            var c = d.movieAddButton_Click();
            Assert.Equal(b, c);
        }
        [Fact]
        public void AddUserTest()
        {
            var a = db.People.FirstOrDefault(p => p.Nickname == selectedNickname);
            var b = currentCompilation.IdPerson += "," + a.Id;
            var c = u.userAddButton_Click();
            Assert.Equal(b, c);
        }
        [Fact]
        public void CreateCompilationTest()
        {
            var a = NameCompTextBox.Text.Trim();
            var newCompilation = new Compilation();
            var b = db.Compilations.Add(newCompilation);
            var c = r.CreateButton_Click();
            Assert.Equal(b, c);
        }
    }
}