using System;

namespace MovieMateTest
{
    [TestClass]
    public class UnitTest1
    {
            MainMenu m = new MainMenu();
            Person currentUser = new Person();
            Movie selectedMovie = new Movie();
            [TestMethod]
            // ���������� � ���������
            public void TestMethod1()
            {
                currentUser = new Person { Id = 1, IdFavorites = "1,2" };
                selectedMovie = new Movie { Id = 2 };
                m.addToFavouritesButton_Click();
                Assert.IsTrue(currentUser.IdFavourites == selectedMovie.Id);
            }
            // ���������� � ������ ������
            public void TestMethod2()
            {
                currentUser = new User { Id = 1, IdBlackList = "1,2" };
                selectedMovie = new Movie { Id = 2 };
                m.addToBlackListButton_Click();
                Assert.IsTrue(currentUser.IdBlackList == selectedMovie.Id);
            }
            // ������� �� ����������
            public void TestMethod3()
            {
                currentUser.IdFavorites = "1,2,3,4,5";
                selectedMovie = new Movie { Id = 3 };
                List<int> movieIds = currentUser.IdFavorites.Split(',').Select(int.Parse).ToList();
                movieIds.Remove(selectedMovie.Id);
                currentUser.IdFavorites = string.Join(",", movieIds);
                Assert.IsFalse(currentUser.IdFavorites.Contains(selectedMovie.Id.ToString()));
            }
            //������� �� ������� ������
            public void TestMethod4()
            {
                currentUser.IdBlackList = "1,2,3,4,5";
                selectedMovie = new Movie { Id = 3 };
                List<int> movieIds = currentUser.IdBlackList.Split(',').Select(int.Parse).ToList();
                movieIds.Remove(selectedMovie.Id);
                currentUser.IdBlackList = string.Join(",", movieIds);
                Assert.IsFalse(currentUser.IdBlackList.Contains(selectedMovie.Id.ToString()));
            }
        }
    }