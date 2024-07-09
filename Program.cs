using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            int number1 = 0;
            int number2 = 1;
            int count = 0;
            Console.WriteLine("The Fibonacci series of given numbers are: ");
            while (count < number)
            {
                Console.WriteLine(number1);
                int sum = number1 + number2;
                number1 = number2;
                number2 = sum;
                count++;
            }

        }
    }
}
