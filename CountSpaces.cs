using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Sentence");
            string sentence = Console.ReadLine();

            int spaces = 0;
            for (int i = 0; i < sentence.Length; i++) 
            {
                if (sentence[i] == ' ') 
                {
                    spaces++ ;
                }
            }
            Console.WriteLine("The Number of spaces are: " + spaces);
        }
    }
}
