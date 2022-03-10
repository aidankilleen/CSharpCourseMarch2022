using System;

namespace ListProcessing
{
    class Program
    {
        static bool CheckEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        static bool CheckOdd(int n)
        {
            return n % 2 == 1;
        }

        delegate int Operation(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }
        delegate bool CheckFunction(int n);

        static void DoOperation(int[] list, Operation op)
        {

        }
        static void ProcessList(int[] list, CheckFunction Fn)
        {
            foreach (int item in list)
            {
                if (Fn(item))
                {
                    Console.WriteLine($"{ item } {Fn(item)}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("List Processing");
            int[] list = { 1, 4, 3, 2, 7, 6, 9, 10, 4, 5, 1, 6 };
            ProcessList(list, CheckEven);
        }
    }
}
