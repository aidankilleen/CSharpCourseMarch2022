using System;
using System.Collections.Generic;
using System.Text;
using UserDaoLibrary;
using System.Linq;

namespace ListProcessing
{
    class ProcessListOfObjects
    {
        static void Main(string[] args)
        {
            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("========================================");
            
            List<User> activeUsers = users.FindAll(u => u.Active);

            foreach (var user in activeUsers)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("=========================================");

            IOrderedEnumerable<User> sortedActiveUsers = activeUsers.OrderBy(user => user.Name );

            foreach(var user in sortedActiveUsers)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("=========================================");

            var sortedInactiveUsers = users.FindAll(u => !u.Active)
                                           .OrderBy(u => u.Name)
                                           .Reverse();

            foreach(var user in sortedInactiveUsers)
            {
                Console.WriteLine(user);
            }

            

        }
    }
}
