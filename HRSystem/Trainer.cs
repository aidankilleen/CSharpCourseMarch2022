using System;
using System.Collections.Generic;
using System.Text;

namespace HRSystem
{
    class Trainer : Employee, ITeacher
    {
        public Trainer(string firstName, 
                       string lastName, 
                       string employeeId)
            :base(firstName, lastName, employeeId)
        {

        }

        public void Teach()
        {
            Console.WriteLine("Listen up, lesson is starting...");
        }
    }
}
