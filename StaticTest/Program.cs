using System;

namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Message.Count = 99;




            Console.WriteLine("Static Test");

            Console.WriteLine(Message.Count);

            Message m1 = new Message("M1", "message 1");
            Console.WriteLine(Message.Count);
            Message m2 = new Message("M2", "message 2");

            Console.WriteLine(Message.Count);


            Console.WriteLine(Message.GetCount());


            string s = "this is a string";


            int i = int.Parse("1234");

            double d = double.Parse("1.2345");


            //double d2 = double.Parse("this is not a number");


            // Math math = new Math();

            Console.WriteLine(Math.PI);

















        }
    }
}
