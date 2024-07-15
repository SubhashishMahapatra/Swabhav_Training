using System;
using System.Security.Policy;

namespace GuessingTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomValue = random.Next(1, 101); 
            int guessCount = 0;

            Console.WriteLine("Guess the Number (between 1 and 100): ");

            int guessValue;
            while (true)
            {
                guessValue = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guessValue == randomValue)
                {
                    Console.WriteLine($"Congrats, You Guessed it in {guessCount} guesses!");
                    break;
                }
                else if (guessValue < randomValue)
                {
                    Console.WriteLine("The Number is greater than your guess!");
                }
                else
                {
                    Console.WriteLine("The Number is smaller than your guess");
                }
            }
        }
    }
}
