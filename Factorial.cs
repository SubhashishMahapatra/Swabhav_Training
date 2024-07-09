using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The Factorial of a given number is: "+factorial);
        }
    }
}
