using System;

namespace String_Manipulation_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string sent = "I really love doing homework at Barnes and Noble.";
            string word;
            string change;

            Console.WriteLine(sent);
            Console.WriteLine("What word from the sentence would you like to look for?");
            word = Console.ReadLine();
            Console.WriteLine("What word would you like to change that to?");
            change = Console.ReadLine();

            if (sent.Contains(word))
            {
                var newsent = sent.Replace(word, change);
                Console.WriteLine(newsent);
            }
            else
            {
                Console.WriteLine("Sorry, I could not find your word");
                //to output changed word backwards
                for (int i = change.Length -1; i >=0 ; i--)
                {
                    Console.Write(change[i]);
                }

            }

            string firstName;
            string lastName;

            Console.WriteLine("enter first name");
            firstName = Console.ReadLine();
            Console.WriteLine("enter your last name");
            lastName = Console.ReadLine();
            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            for (int i = 0; i <firstName.Length; i = i + 1)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter + " ");
            }
            for (int i = 0; i < lastName.Length; i = i + 1)
            {
                char currentLetter = lastName[i];
                Console.WriteLine(currentLetter + " ");
            }
            Console.WriteLine("First initial is " + firstInitial);
            Console.WriteLine("Last initial is " + lastInitial);

            

            for (int i = firstName.Length -1; i >= 0; i--)
            {
                Console.WriteLine(firstName[i]);
            }

            Console.ReadKey();
        }   
    }
}
