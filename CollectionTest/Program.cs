using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Test");

            int[] list = { 1, 5, 3, 8, 6, 9, 2, 8, 3, 9 };
            int[] list2 = new int[10];

            // no (easy) way of adding a new item to the end of the list

            // Collection classes  - note it is not type safe
            ArrayList al = new ArrayList();

            al.Add("one");
            al.Add("two");
            al.Add("three");
            al.Add("four");
            // al.Add(5);

            foreach(string item in al)
            {
                Console.WriteLine(item.ToUpper());
            }

            // Generic Collection

            List<string> days = new List<string>();

            days.Add("Mon");
            days.Add("Tue");
            days.Add("Wed");
            days.Add("Thu");
            days.Add("Fri");
            days.Add("Sat");
            days.Add("Sun");
            //days.Add(7);


            foreach (string day in days)
            {
                Console.WriteLine(day.ToUpper());
            }
            


































        }
    }
}
