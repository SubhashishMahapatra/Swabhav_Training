using System;

public class Reverse
{

    static void Main(string[] args)
    {

        int inputNumber;
        int lastDigit;
        int reverseNumber = 0;

        Console.WriteLine("Enter a Number :");

        inputNumber = int.Parse(Console.ReadLine());

        while (inputNumber > 0)
        {

            lastDigit = inputNumber % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            inputNumber /= 10;         

        }

        Console.WriteLine("The Reverse of the given number is: {0}", reverseNumber);

    }

}
