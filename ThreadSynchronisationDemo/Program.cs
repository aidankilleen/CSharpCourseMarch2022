using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronisationDemo
{
    class Program
    {
        public static int acc1 = 1000;
        public static int acc2 = 1000;
        public static Mutex mutex = new Mutex();

        public static void Transfer()
        {
            Random rnd = new Random();

            mutex.WaitOne();
            if (rnd.Next(10) > 5 )
            {
                acc1 += 10;
                acc2 -= 10;
            } else
            {
                acc1 -= 10;
                acc2 += 10;
            }
            mutex.ReleaseMutex();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Thread Synchronization Demo");
            List<Task> tasks = new List<Task>();
            Random rnd = new Random();

            Task t = Task.Factory.StartNew(() => {
                Console.WriteLine("task 1 starting...");
                for (int i=0; i<1000000; i++)
                {
                    //Console.WriteLine($"task 1 working {i}");
                    Transfer();
                    //Thread.Sleep(rnd.Next(50, 250));
                }
                Console.WriteLine("task 1 finished"); 
            });
            tasks.Add(t);

            Task t2 = Task.Factory.StartNew(() => {
                Console.WriteLine("task 2 starting...");
                for (int i = 0; i < 1000000; i++)
                {
                    //Console.WriteLine($"task 2 working {i}");
                    Transfer();
                    //Thread.Sleep(rnd.Next(50, 250));
                }
                Console.WriteLine("task 2 finished");
            });
            tasks.Add(t2);


            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("Main Finished");

            Console.WriteLine($"Acc1: {acc1}");
            Console.WriteLine($"Acc2: {acc2}");
            Console.WriteLine($"{acc1 + acc2}");

        }
    }
}
