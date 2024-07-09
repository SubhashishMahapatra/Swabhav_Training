using System;

public class Prime
{

    static void Main(string[] args)
    {

        int num;

        Console.WriteLine("Enter a Number :");

        num = int.Parse(Console.ReadLine());

        if (PrimeNumber(num))
        {
            Console.WriteLine("The number "+ num +" is a Prime Number");
        }
        else
        {
            Console.WriteLine("The number "+ num +" is Not a Prime Number");

        }
    }

    static bool PrimeNumber(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;

    }
}
