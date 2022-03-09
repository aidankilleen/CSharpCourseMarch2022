using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    class GarbageCollectorTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garbage Collector Test");


            for (int i=0; i< 100000; i++)
            {
                Message m = new Message($"Message {i}", $"This is message {i}");
                Console.WriteLine(m.Text);
            }

            Console.WriteLine($"There are {Message.Count} messages left in memory");


        }
    }
}
