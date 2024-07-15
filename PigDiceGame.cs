using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int turn = 0;
            int totalScore = 0;
            int targetScore = 20;

            Console.WriteLine("Let's Play PIG!\n");
            Console.WriteLine("* See how many turns it takes you to get to 20.");
            Console.WriteLine("* Turn ends when you hold or roll a 1.");
            Console.WriteLine("* If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("* If you hold, you save all points for the turn.\n");

            while (totalScore < targetScore)
            {

                turn++;
                int turnScore = 0;
                Console.WriteLine();
                Console.WriteLine($"TURN: {turn}");
                Console.WriteLine("Welcome to the game of Pig!");

                bool turnOver = false;

                while (!turnOver)
                {
                    Console.WriteLine("Enter 'r' to roll again, 'h' to hold.");
                    char playerChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (playerChoice == 'r')
                    {

                        int roll = rnd.Next(1, 7);
                        Console.WriteLine($"You rolled: {roll}");

                        if (roll == 1)
                        {
                            turnScore = 0;
                            turnOver = true;
                            Console.WriteLine("Turn over. No Score");
                        }
                        else
                        {
                            turnScore += roll;
                            Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}");
                            Console.WriteLine($"If you hold, you will have {totalScore + turnScore} points!");
                        }
                    }
                    else if (playerChoice == 'h')
                    {
                        totalScore += turnScore;
                        turnOver = true;
                        Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'r' to roll again or 'h' to hold.");
                    }

                }
                if (totalScore >= targetScore)
                {
                    Console.WriteLine($"You Win! You finished in {turn} turns!");
                    Console.WriteLine("Game over!");
                }


            }

        }
    }
}
