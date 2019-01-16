using System;

namespace BriansGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please guess a number between 1 and 10 or enter 0 for help");
            string userGuess = Console.ReadLine();

            if (userGuess.Equals("0"))
            {
                Console.WriteLine("Game Instructions are:");
                Console.WriteLine("Guess a Number betwwen 1 and 10");
                Console.WriteLine("Hit Enter to submit your guess.");

                userGuess = Console.ReadLine();
            }

            Console.WriteLine("You guessed: " + userGuess);

            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
                                           

        }
    }
}
