using System;

namespace BriansGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You Guessed: " + userGuess);

           
            if (userGuess.Equals("7"))
            {               
                Console.WriteLine("You Win!");
            }
            else
            {            
                Console.WriteLine("You Lose");
            }
            

        }
    }
}
