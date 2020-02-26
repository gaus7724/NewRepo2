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

            /*  while (index >=0)
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
              } */

            for (int i = userInput.Length -1; i >= 0; i--)
            {
                userInputReversed += userInput[i];
            }
            if (userInputReversed == userInput)
            {
                Console.WriteLine($"Congrats! Your word {userInput} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Sorry. Your word {userInput} is not a palindrome. Your word reversed is {userInputReversed}");
            }

            Console.ReadKey();
        }
    }
}