using System;
using System.Collections.Generic;

namespace UserDaoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserDao Test");

            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();

            foreach(User u in users)
            {
                Console.WriteLine(u);
            }

            User bobby = dao.GetUser(54);
            Console.WriteLine(bobby);

            dao.DeleteUser(54);
            bobby = dao.GetUser(54);
            Console.WriteLine(bobby == null ? "Exists" : "Doesn't exist");


            User harriet = dao.GetUser(58);

            harriet.Name = "CHANGED";
            harriet.Email = "changed@gmail.com";
            harriet.Active = !harriet.Active;

            dao.UpdateUser(harriet);

            User newUser = new User();
            newUser.Name = "NEW USER";
            newUser.Email = "new.user@gmail.com";
            newUser.Active = false;


            dao..AddUser(newUser);





            dao.Close();

        }
    }
}
