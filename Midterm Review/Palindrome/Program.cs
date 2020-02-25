using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userInputReversed = "";
            int index;
            



            Console.WriteLine("Please enter a word or phrase.");
            userInput = Console.ReadLine();
            userInput.ToLower();
            index = userInput.Length - 1;

            while (index >=0)
            {
                userInputReversed += userInput[index];
                index--;
            }
            userInputReversed.ToLower();
            if (userInputReversed == userInput)
            {

                Console.WriteLine("Congrats! Your word " + userInput + "is a palindrome");
            }
            else
            {
                Console.WriteLine("Your word " + userInput + " is not a palindrome. Your word reversed is " + userInputReversed);
            }

            Console.ReadKey();
        }
    }
}