using System;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HR System");

            Person p = new Person("Aidan", "Killeen");
            p.Display();

            Employee e = new Employee("Alice", "Adams", "E12345");
            e.Display();

            Contractor c = new Contractor("Bob", "Bennet", "CPL");
            c.Display();

            Manager m = new Manager("Carol", "Conway", "E54321", 15);
            m.Display();
        }
    }
}
