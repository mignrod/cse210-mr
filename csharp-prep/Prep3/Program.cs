using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            Random randomNumber = new Random();

            int magicNumber = randomNumber.Next(1, 100);

            Console.WriteLine("Welcome to the number guessing game! Try to guess the Magic Number between 1 and 100.");

            int guess = 0;
            int intents = 0;

            do 
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                intents += 1;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");

                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");

                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You have try {intents} times.");

                }
            } while (guess != magicNumber);
            Console.Write("Do  you want to play again? (yes or no / y or n) ");
            response = Console.ReadLine();

        } while (response == "yes" || response == "y");

    }
}