using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumber = { 1, 2, 3, 4, 5 };
  
            Console.WriteLine("The maximum number is: " + MaximumNumber(randomNumber));
        }

        static int MaximumNumber(int[] maxNumber)
        {
            int maximumNumber = 0;
            foreach (int number in maxNumber)
            {
                if (number > maximumNumber)
                {
                    maximumNumber = number;
                }


            }
            return maximumNumber;
        }
    }
}
