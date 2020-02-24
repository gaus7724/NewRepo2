// DaysInMonth
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Review
{
    class Program
    {
        static void Main(string[] args)
        {

            String InputMonth;
            int DaysInTheMonth;
            string FebAnswer;

            Console.WriteLine("Input the current month.");
            InputMonth = Console.ReadLine();

            if (InputMonth.ToUpper() == "APRIL")
            {
                DaysInTheMonth = 30;
            }
            else if (InputMonth.ToUpper() == "JUNE")
            {
                DaysInTheMonth = 30;
            }
            else if (InputMonth.ToUpper() == "SEPTEMBER")
            {
                DaysInTheMonth = 30;
            }
            else if (InputMonth.ToUpper() == "NOVEMBER")
            {
                DaysInTheMonth = 30;
            }
            else if (InputMonth.ToUpper() == "FEBRUARY")
            {
                Console.WriteLine("Is it a leap year? Y or N");
                FebAnswer = Console.ReadLine();
                FebAnswer.ToUpper();
                if (FebAnswer == "Y")
                {
                    DaysInTheMonth = 29;
                }
                else
                {
                    DaysInTheMonth = 28;
                }

            }
            else
            {
                DaysInTheMonth = 31;
            }
            Console.WriteLine("The number of days in " + InputMonth + " is " + DaysInTheMonth);
            Console.ReadKey();
        }
    }
}
