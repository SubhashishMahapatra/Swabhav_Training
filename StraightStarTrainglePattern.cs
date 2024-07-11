using System;

class Pattern
{
    public static void Main(string[] args)
    {
        StarPattern(5);
    }

    static void StarPattern(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            Stars(i);
            Console.WriteLine();
        }
    }

    static void Stars(int count)
    {
        for (int i = 0; i <= count; i++)
        {
            Console.Write("*");
        }
    }
}
