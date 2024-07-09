using System;

class CommandLineDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Count of Inputs: " + args.Length);

        int sum = 0;
        int max_number = int.Parse(args[0]);
        int min_number = int.Parse(args[0]);

        for (int i = 0; i < args.Length; i++)
        {
            int value = int.Parse(args[i]);
            sum += value;

            if (value > max_number)
            {
                max_number = value;
            }

            if (value < min_number)
            {
                min_number = value;
            }
        }

        int avg = sum / args.Length;

        Console.WriteLine("Sum of the numbers are: " + sum);
        Console.WriteLine("Average of the numbers are: " + avg);
        Console.WriteLine("Maximum number is: " + max_number);
        Console.WriteLine("Minimum number is: " + min_number);
    }
}