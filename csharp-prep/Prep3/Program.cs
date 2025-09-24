using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        do
        {
            int guessCount = 1;

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != magicNumber)
            {
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

                Console.Write("What is your next guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount += 1;
            }

            Console.WriteLine($"You got it in {guessCount} guesses!");
            Console.Write("Would you like to play again? (Please type, 'yes' or 'no') ");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");
    }
}