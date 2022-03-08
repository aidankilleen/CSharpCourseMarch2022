using System;
using System.Collections.Generic;
using System.Text;

namespace HRSystem
{
    class Contractor : Person
    {
        public string Agency { get; set; }

        public Contractor(string firstName, 
                          string lastName, 
                          string agency)
            :base(firstName, lastName)
        {
            Agency = agency;
        }

        public override void Display()
        {
            Console.WriteLine("Contractor:");
            base.Display();
            Console.WriteLine($"Agency: {Agency}");
        }
    }
}
