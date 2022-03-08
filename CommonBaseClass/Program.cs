using System;

namespace CommonBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Common Base Class");

            Person p = new Person("Alice", "Adams");

            Console.WriteLine(p);

            Person p2 = new Person("Alice", "Adams");

            if (p.Equals(p2))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }

            Person p3 = p;

            if (p == p3)
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }


           

            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Now;

            //dt.Millisecond = 0;
            //dt2.Millisecond = 0;

            if (dt.Equals(dt2))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }




        }
    }
}
