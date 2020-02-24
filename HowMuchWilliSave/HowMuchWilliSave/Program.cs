using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchWilliSave
{
    class Program
    {
        static void Main(string[] args)
        {
            double AmountSavedPerWeek;
            double interest;
            int years = 1;
             double totalAmtSaved = 0;
            double AmountSavedPerMonth;

            Console.WriteLine("How much money do you save a week?");
            string AmountSavedPerWeekAsString = Console.ReadLine();
            AmountSavedPerWeek = Convert.ToDouble(AmountSavedPerWeekAsString);

            Console.WriteLine("What is your interest rate per month?");
            string InterestAsString = Console.ReadLine();
            interest = Convert.ToDouble(InterestAsString);
            interest = (interest / 100) + 1;

            Console.WriteLine("How many years do you want to save?");
            string yearAsString = Console.ReadLine();
            years = Convert.ToInt32(yearAsString);


            for (int i = 1; i < years * 12; i++)
            {
                AmountSavedPerMonth = AmountSavedPerWeek * 4;
                totalAmtSaved = (AmountSavedPerMonth + totalAmtSaved) * interest;
                totalAmtSaved.ToString("C2");
                Console.WriteLine("For month " + i + " and year " + i / 12 + " money saved so far is " + totalAmtSaved);

            }
            Console.ReadKey();
        }
    
    }
}
