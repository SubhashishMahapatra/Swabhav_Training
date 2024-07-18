using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Sentence");
            
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Word count is: " + words.Length);
        }
    }
}
