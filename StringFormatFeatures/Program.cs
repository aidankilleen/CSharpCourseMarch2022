using System;

namespace StringFormatFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Format Features");

            string message = "hello";

            Console.WriteLine(message);

            int answer = 99;

            Console.WriteLine("The answer is " + answer);

            message = String.Format("The answer is {0}", answer);

            Console.WriteLine(message);

            int a = 10;
            int b = 20;

            message = String.Format("{0} + {1} = {2}", a, b, a + b);

            Console.WriteLine(message);


            double price = (double)22 / 7;

            message = String.Format("The price is {0:C2}", price);

            Console.WriteLine(message);

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);


            Console.WriteLine("newline \n  if you need quotes you can put \"them\" in your string");


            Console.WriteLine("tab \t  if need to put in a path c:\\program files\\microsoft\\csharp");



            string file = "c:\\Users\\admin\\Downloads\\file1.txt";

            Console.WriteLine(file);

            file = @"c:\Users\admin\Downloads\file1.txt";

            Console.WriteLine(file);


            string name = "Aidan";
            message = $"my name is { name }";

            Console.WriteLine(message);


            Console.WriteLine($"{a} + {b} = { a + b }");


            Random rnd = new Random();

            int r = rnd.Next(10);


            message = $"the number is {r} it is { (r > 5 ? "big" : "small") }";

            Console.WriteLine(message);


            string multiline = @" you can have

a raw string that


spans multiple line";


            Console.WriteLine(multiline);



            multiline = $@"

            {a}
        +   {b}
        --------
            {a + b}
";

            Console.WriteLine(multiline);


            Console.WriteLine();















































                

        }
    }
}
