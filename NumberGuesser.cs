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

            Console.WriteLine("Welcome to Guess Number Game \nYou Will Be Asked To Guess A Number To Win The Game");

            Console.WriteLine("Guess the Number (between 1 and 100): ");

            int guessValue;
            while (true)
            {
                guessValue = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guessValue == randomValue)
                {
                    Console.WriteLine($"You took {guessCount} tries! You Win the Game!");
                    break;
                }
                else if (guessValue < randomValue)
                {
                    Console.WriteLine("oops! sorry, too low.");
                }
                else
                {
                    Console.WriteLine("oops! sorry, too high.");
                }
            }
        }
    }
}
