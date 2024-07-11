using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        //public const int EVEN = 2;
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a Number: ");
            number = int.Parse(Console.ReadLine());

            int value = 1;
            int sum = 0;
            while (value <= number / 2)
            {
                if (number % value == 0)
                { 
                    sum += value; 
                }
                value++;
            }

            Console.WriteLine(sum == number ? "Perfect" : "Not Perfect");
        }
    }
}

