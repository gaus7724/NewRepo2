using System;

namespace More_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string firstName = "";
             string lastName = "";


             Console.WriteLine("enter your first name");
             firstName = Console.ReadLine();
             firstName.ToLower();
             Console.WriteLine("enter you last name");
             lastName = Console.ReadLine();

             /*  char firstInitial = firstName[0];
               char lastInitial = lastName[0];

               Console.WriteLine("Your first initial is " +firstInitial + "and your last inital is " +lastInitial);

               firstName.ToString();
               */
            // string firstNameReversed = "";

            //output first name backwards one character at a time

            /* for (int i = firstName.Length -1; i >= 0; i--)
             {
                 Console.WriteLine(firstName[i]);
             }
             */
            /*  int Index = firstName.Length - 1;

              while (Index >= 0)
              {
                  firstNameReversed += firstName[Index];
                  Index--;
              }
              Console.WriteLine(firstNameReversed); */

            /* for (int i = firstName.Length -1; i >= 0; i--)
             {
                 firstNameReversed += firstName[i]; 
             }
             Console.WriteLine(firstNameReversed);
             firstNameReversed.ToLower();

             if (firstNameReversed== firstName)
             {
                 Console.WriteLine("palindrome");
             }
             else
             {
                 Console.WriteLine("not a palindrome");
             }
             string firstNameReversedAgain = "";

             for (int i = firstNameReversed.Length -1; i <= 0; i++)
             {
                 firstNameReversedAgain += firstNameReversed[i];

             }
             Console.WriteLine(firstNameReversedAgain);
             */
              string sent = "I love studying programming.";
              string search = "";
              string replace = "";


              Console.WriteLine("what word would you like to look for?");
              search = Console.ReadLine();

              Console.WriteLine("What word would you like to change that to?");
              replace = Console.ReadLine();

              string newSent = "";
            if (sent.Contains(search))
            {
                newSent = sent.Replace(search, replace);
                Console.WriteLine(newSent);
            }
            else
            {
                Console.WriteLine("sorry. that word is not in the sentence");
                //outputs word reversed in one line
                /* for (int i = replace.Length - 1; i >= 0; i--)
                 {
                     Console.Write(replace[i]);

                 } */
                 string replaceReversed = "";
                 int index = replace.Length -1;
                 //outputs word reversed in one line
                 while (index >= 0)
                 {
                     replaceReversed += replace[index];
                     index--;
                 }
                 Console.WriteLine(replaceReversed);
                 //outputs everyother letter in one line
                for (int i = 0; i <= replace.Length -1; i= i + 2)
                {
                    Console.Write
                        (replace[i]);
                }
                
            }
              
           /* Random rnd = new Random();
           int rndNum = rnd.Next(0, 10);
            int rndNum2 = rnd.Next(0, 10);
            int sum = 0;
            int guess = 0;
            do
            {
                sum = rndNum + rndNum2;
                Console.WriteLine("What is the sum of " + rndNum +  "and " + rndNum2 + " ?");
                string guessAsString = Console.ReadLine();
                guess = Convert.ToInt32(guessAsString);

                if (guess != sum)
                {
                    Console.WriteLine("Sorry. Guess again");
                }
                else
                {
                    Console.WriteLine("Congrats! You're correct.");
                }

            } while (guess != sum); */

            Console.ReadKey();
        }

    }
}
