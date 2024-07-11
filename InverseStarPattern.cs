using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStarPattern(5);
        }
        static void PrintStarPattern(int rows)
        {
            for (int i = rows; i > 0; i--)
            {
                PrintStars(i);
                Console.WriteLine();
            }


        }
        static void PrintStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
        }
    }
}
