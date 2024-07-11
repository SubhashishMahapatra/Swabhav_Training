using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            string name = Console.ReadLine();
            string reversedString = ReverseString(name);

            if (name == reversedString)
            {
                Console.WriteLine("The Given String is Palindrome");
            }
        }

        static string ReverseString(string str)
        {
            string reversedString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }
            return reversedString;
        }
    }
}
