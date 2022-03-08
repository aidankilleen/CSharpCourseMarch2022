using System;
using System.Collections.Generic;
using System.Text;

namespace HRSystem
{
    class Tutor : Contractor, ITeacher
    {
        public Tutor(string firstName, 
                     string lastName, 
                     string agency)
            :base(firstName, lastName, agency)
        {

        }

        public void Teach()
        {
            Console.WriteLine("Please listen, the class is beginning");
        }
    }
}
