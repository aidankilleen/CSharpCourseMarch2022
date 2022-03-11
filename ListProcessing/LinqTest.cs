using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UserDaoLibrary;

namespace ListProcessing
{
    class LinqTest
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Random r = new Random();

            for (int i = 0; i< 20; i++)
            {
                list.Add(r.Next(11));
            }

            foreach(int item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            list.ForEach(item => Console.Write($"{item} "));


            Console.WriteLine();

            // explore the linq syntax
            IEnumerable<int> result = from item in list select item;


            foreach(int item in result)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n-----------------------------------");
            var evenNumbers = list.Where(item => item % 2 == 0);

            foreach(int item in evenNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            var evenNumbersFromLinq = from item in list where item % 2 == 0 select item;

            foreach (int item in evenNumbersFromLinq)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("-----------------------------------------");

            UserDao dao = new UserDao();

            List<User> users = dao.GetUsers();

            var activeUsers = from user in users where user.Active select user;

            foreach(User user in activeUsers)
            {
                Console.WriteLine($"{user.Name} {user.Active}");
            }

            Console.WriteLine("------------------------------------------");


            var agg = from user in users 
                      group user by user.Active into g 
                      select new { 
                        Active = g.Key, 
                        Count = g.Count()
                      };

            foreach (var item in agg)
            {
                Console.WriteLine(item);
            }















            dao.Close();











        }
    }
}
