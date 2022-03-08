using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling");
            int a = 10;
            int b = 0;
            int answer;
            int[] list = { 1, 4, 2, 7, 9, 5, 3, 8 };
            string number = null;


            answer = a / b;


            Random rnd = new Random();
            int r = rnd.Next(5);
            try
            {
                switch(r)
                {
                    case 0:
                        answer = list[8];
                        break;
                    case 1:
                        answer = a / b;
                        break;
                    case 2:
                        answer = number.Length;
                        break;
                    case 3:
                        throw new SystemException("System error occurred");
                    default:
                        answer = 42;
                        break;
                }

            } catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                answer = 0;
            } catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("list item doesn't exist");
                answer = list[0];
            } catch(NullReferenceException ex)
            {
                Console.WriteLine("the string is null");
                answer = 0;
            } catch(Exception ex)
            {
                Console.WriteLine("some other error occurred");
                Console.WriteLine(ex.Message);
                answer = -1;
            }


            try
            {

            } catch(Exception ex)
            {

            }


            Console.WriteLine($"Answer: { answer }");
            Console.WriteLine("finished");

            /*
            try
            {
                DoSomething();
                DoSomethingElse();

            } catch(NetworkException ex)
            {
                
            } catch(BadDataException ex)
            {

            } catch(Exception ex)
            {
                // some other exception occurred.
            }
            */



            /*
            int r = DoSomething();

            if (r == 0)
            {
                // everything is ok
            } else if (r == -1)
            {
                // network error
            } else if (r ==-2)
            {
                // data error
            } else
            {
                // some other error
            }
            r = DoSomethingElse();
            if (r == 0)
            {
                // everything is ok
            }
            else if (r == -1)
            {
                // network error
            }
            else if (r == -2)
            {
                // data error
            }
            else
            {
                // some other error
            }
            */
        }
    }
}
