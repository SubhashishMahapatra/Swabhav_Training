using System;

class Program
{
    static void Main()
    {
        CurrencyCalculator();

    }

    static void CurrencyCalculator()
    {
        int[] denominations = { 2000, 500, 200, 100 };

        Console.WriteLine("Enter an amount (not exceeding 50000 and must be a multiple of 100):");
        int amount;

        while (true)
        {
            string input = Console.ReadLine();


            if (int.TryParse(input, out amount))
            {

                if (amount > 0 && amount <= 50000 && amount % 100 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter an amount not exceeding 50000 and must be a multiple of 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }


        Console.WriteLine("Denominations for the amount " + amount + ":");
        foreach (int denomination in denominations)
        {
            int count = amount / denomination;
            amount %= denomination;
            Console.WriteLine(+denomination + ":" + count);
        }
    }
}
