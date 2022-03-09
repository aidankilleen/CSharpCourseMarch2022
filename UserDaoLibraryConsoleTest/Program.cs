using System;
using System.Collections.Generic;
using UserDaoLibrary;

namespace UserDaoLibraryConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Dao Library Test");

            UserDao dao = new UserDao();
            
            List<User> users = dao.GetUsers();

            foreach(User user in users)
            {
                Console.WriteLine(user);
            }
            dao.Close();
        }
    }
}
