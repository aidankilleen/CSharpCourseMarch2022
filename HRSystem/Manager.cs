using System;
using System.Collections.Generic;
using System.Text;

namespace HRSystem
{
    class Manager : Employee
    {
        public int HeadCount { get; set; }

        public Manager(string firstName, 
                        string lastName, 
                        string employeeId, 
                        int headCount)
            :base(firstName, lastName, employeeId)
        {
            HeadCount = headCount;
        }

        public override void Display()
        {
            Console.WriteLine("Manger:");
            base.Display();
            Console.WriteLine($"HeadCount:{HeadCount}");
        }
    }
}
