using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            string reverseString = "";

            Console.WriteLine("Enter a String: ");

            inputString = Console.ReadLine();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverseString += inputString[i];
            }

            Console.WriteLine("The Reverse of the String is: " + reverseString);

            if (inputString.ToLower() == reverseString.ToLower())
            {
                Console.WriteLine("The Given String is Palindrome");
            }
            else
            {
                Console.WriteLine("The Given String is not Palindrome");


            }
        }

    }
}
