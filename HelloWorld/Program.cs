using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment

            /*
             * This is a multiline comment
             */

            Console.WriteLine("Hello World!");  
            Console.WriteLine("send output to the screen");
            Console.WriteLine();

            string name = "Aidan";
            string firstName = "Aidan";
            string lastName = "Killeen";

            string first_name = "Aidan";    // avoid using underscores in variable names

            int count = 0;
            double pi = 3.14159;

            //name = 21;

            var course = "C# Training Course";
            var duration = 5;

            int value;

            //value = 100 / 20;

            //Console.WriteLine("The value is " + value);  // can't use uninitialised variables


            // Expressions
            value = 99 / 20;

            int a = 10;
            int b = 20;

            value = (a * b) + (6 ^ 2);   // use brackets to ensure the order of operations is
                                         // what you are expecting

            int i = 99;
            Console.WriteLine(i++);
            i += 20;
            // equivalent to 
            i = i + 20;


            // conditions
            Random rnd = new Random();

            int r = rnd.Next(100);
            Console.WriteLine(r);
            if (r < 30)
            {
                Console.WriteLine("small");
            }
            else if (r < 60)
            {
                Console.WriteLine("medium");
            }
            else
            {
                Console.WriteLine("large");
            }

            // 
            r = rnd.Next(5);
            Console.WriteLine(r);
            switch(r)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            r = rnd.Next(10);

            Console.WriteLine("The number is " + r + " it is " + (r > 5 ? "big" : "small"));
            int x = 10;

            if (x == 10)
            {
                Console.WriteLine("Ten");
            }
            // !=   not equal
            // >=  greater than or equal
            // <=  less than or equal


            // Loops 
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            i = 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("=========================================");
            //  arrays
            int[] list = { 1, 4, 2, 6, 4, 9, 3 };

            Console.WriteLine(list[1]);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Length);

            // Console.WriteLine(list[100]);  // we cannot access item outside array bounds

            string[] days = { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };

            for (i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
            Console.WriteLine("====================================");
            
            foreach(string day in days)
            {
                Console.WriteLine(day);
            }

            // functions
            Console.WriteLine("message");

            rnd.Next(100);

            Console.WriteLine(CalculateTheAnswer(10, 20));


            // objects







        }

        static int CalculateTheAnswer(int a, int b)
        {
            return a + b;
        }
    }
}
