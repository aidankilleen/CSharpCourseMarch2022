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


            Console.WriteLine("==============================");

            Person[] people =
            {
                new Person("Aidan", "Killeen"),
                new Employee("Alice", "Adams", "E12345"),
                new Contractor("Bob", "Bennet", "CPL"),
                new Manager("Carol", "Conway", "E54321", 15)
            };

            foreach (Person person in people)
            {
                person.Display();
            }
            Console.WriteLine("------------------------");
            
            Trainer t = new Trainer(
                    "Dan", "Dunne", "E22222");
            t.Teach();

            Tutor tut = new Tutor("Eve", "Evans", "CPL");
            tut.Teach();

            Console.WriteLine("--------------------------");

            ITeacher[] faculty =
            {
                new Trainer("Dan", "Dunne", "E22222"),
                new Tutor("Eve", "Evans", "CPL"), 
                new Trainer("Fred", "Flintstone", "E11112"), 
                new Tutor("Ger", "Griffin", "Reperio"), 
                new Trainer("Harriet", "Harrington", "E11113")
            };

            foreach (ITeacher teacher in faculty)
            {
                teacher.Teach();

                Person person = (Person)teacher;
                person.Display();
            }
        }
    }
}
