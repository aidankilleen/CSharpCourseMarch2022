using System;
using UserDaoLibrary;

namespace UserDaoLibraryFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Dao Features");

            DaoFeatures daof = new DaoFeatures();


            daof.ExerciseGetUser();



            daof.ExerciseDeleteUser();


        }
    }
}
