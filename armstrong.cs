using System;

public class Armstrong
{
    static void Main(string[] args)
    {
        int num;
        int digit;
        int temp;
        int result = 0;
        int power;

        Console.WriteLine("Enter a Number: ");
        num = int.Parse(Console.ReadLine());

        temp = num;
        power = GetDigitCount(num);

        while (temp > 0)
        {
            digit = temp % 10;
            result += (int)Math.Pow(digit, power);
            temp /= 10;
        }
        Console.WriteLine("The Result of a given number is: "+result);
        if (result == num)
        {
            Console.WriteLine("Hence the number is Armstrong");
        }

        else
        {
            Console.WriteLine("Hence number is Not a Armstrong");
        }

    }

    static int GetDigitCount(int n)
    {
        int count = 0;

        while (n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

}
