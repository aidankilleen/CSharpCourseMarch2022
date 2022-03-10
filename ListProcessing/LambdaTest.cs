using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListProcessing
{
    class LambdaTest
    {

        static void MyAction(int i)
        {
            Console.WriteLine($"the value is { i }");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Lambda Expression Test");
            int[] array = { 1, 4, 3, 2, 6, 5, 8, 7, 10, 8, 9 };
            List<int> list = array.ToList();

            // list.ForEach(MyAction);

            list.ForEach((i) => {

                Console.WriteLine($"the value is { i }");
            
            });

            List<int> evenNumbers = list.FindAll((i) =>
                      {
                          if (i % 2 == 0)
                          {
                              return true;
                          }
                          else
                          {
                              return false;
                          }
                      });

            evenNumbers.ForEach((i) =>
            {
                Console.WriteLine(i);
            });

            Console.WriteLine("--------------------------------------");
            // rewrite using some shortcuts

            evenNumbers = list.FindAll(i => i % 2 == 0);

            evenNumbers.ForEach((i) =>
            {
                Console.WriteLine(i);
            });





        }
    }
}
