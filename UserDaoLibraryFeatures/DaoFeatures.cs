using System;
using System.Collections.Generic;
using System.Text;
using UserDaoLibrary;

namespace UserDaoLibraryFeatures
{
    class DaoFeatures
    {
        UserDao dao = new UserDao();

        public void ExerciseGetUser()
        {
            try
            {
                User u = dao.GetUser(9999);
                Console.WriteLine(u.Name);
            }
            catch (UserDaoException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ExerciseDeleteUser()
        {
            try
            {
                dao.DeleteUser(9999);
            }
            catch (UserDaoException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
