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
            string[] studentfirstnames = { "subhashish", "prasad", "akash", "rohit", "atharva" };
      
            foreach (string firstname in studentfirstnames)
            Console.WriteLine("student first names are: {0} ", firstname);

        }
    }
}
