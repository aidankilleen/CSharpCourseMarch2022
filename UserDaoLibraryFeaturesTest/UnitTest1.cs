using NUnit.Framework;
using UserDaoLibrary;

namespace UserDaoLibraryFeaturesTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            UserDao dao = new UserDao();
            Assert.IsNotNull(dao);
            dao.Close();
        }

        [Test]
        public void TestUserNotFound()
        {
            UserDao dao = new UserDao();

            Assert.Throws<UserDaoException>(() =>
            {
                dao.GetUser(9999);
            });
            dao.Close();
        }

        [Test]
        public void TestUserNotDeleted()
        {
            UserDao dao = new UserDao();
            Assert.Throws<UserDaoException>(() =>
            {
                dao.DeleteUser(9999);
            });
            dao.Close();
        }

        [Test]
        public void TestAddUser()
        {
            UserDao dao = new UserDao();

            User userToAdd = new User();
            userToAdd.Name = "Aidan";
            userToAdd.Email = "aidan@gmail.com";
            userToAdd.Active = true;

            User addedUser = dao.AddUser(userToAdd);
            Assert.AreNotEqual(0, addedUser.Id);

            dao.Close();
        }

        [Test]
        public void TestUpdateUser()
        {
            UserDao dao = new UserDao();

            User userToAdd = new User();
            userToAdd.Name = "Aidan";
            userToAdd.Email = "aidan@gmail.com";
            userToAdd.Active = true;

            User addedUser = dao.AddUser(userToAdd);

            addedUser.Name = "CHANGED";
            addedUser.Email = "changed@gmail.com";
            addedUser.Active = false;

            dao.UpdateUser(addedUser);
            User updatedUser = dao.GetUser(addedUser.Id);
            Assert.AreEqual(addedUser, updatedUser);

            dao.Close();
        }

        [Test]
        public void TestAddWithApostophe()
        {
            UserDao dao = new UserDao();

            User userToAdd = new User();
            userToAdd.Name = "Mary O'Sullivan";
            userToAdd.Email = "mos@gmail.com";
            userToAdd.Active = true;

            User addedUser = dao.AddUser(userToAdd);
            Assert.AreNotEqual(0, addedUser.Id);

            dao.Close();
        }

        [Test]
        public void TestSqlInjection()
        {
            UserDao dao = new UserDao();

            User userToSacrifice = new User();
            userToSacrifice.Name = "Scrificial User";
            userToSacrifice.Email = "mos@gmail.com";
            userToSacrifice.Active = true;

            dao.AddUser(userToSacrifice);

            User userToAdd = new User();
            userToAdd.Name = $"','',0); delete from users where id = {userToSacrifice.Id};--";
            userToAdd.Email = "mos@gmail.com";
            userToAdd.Active = true;

            User addedUser = dao.AddUser(userToAdd);

            Assert.DoesNotThrow(()=>dao.GetUser(userToSacrifice.Id));

            dao.Close();
        }




    }
}