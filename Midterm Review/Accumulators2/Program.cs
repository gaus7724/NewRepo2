using System;

namespace Accumulators2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int sum = 0;
            double mult = 1;

             for (counter = 1; counter < 101; counter++)
             {
                 sum += counter;
                 mult *= counter;

             }
             
           /* while (counter <= 100)
            {
                sum += counter;
                mult *= counter;
                counter++; 
            }
            */
            Console.WriteLine("The summation of 1-100 is" + sum.ToString("N0"));
            Console.WriteLine("The multiplication of 1-100 is" + mult.ToString("N0"));
            Console.ReadKey();
        }

    }
}
