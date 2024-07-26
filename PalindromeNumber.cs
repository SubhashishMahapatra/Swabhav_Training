class Program
{
    static void Main(string[] args)
    {
        const int VALUE = 10;

        Console.Write("Enter a Number :");
        int number = int.Parse(Console.ReadLine());
        int temperoryValue = number;

        int reverse = 0;



        while (temperoryValue > 0)
        {

            int remainder = temperoryValue % VALUE;
            reverse = reverse * VALUE + remainder;
            temperoryValue = temperoryValue / VALUE;


        }

        if (number == reverse)
        {
            Console.WriteLine("Reverse of number is "+reverse+"\nHence Number is Palindrome");
        }
        else 
        {
            Console.WriteLine("Reverse of number is " + reverse + "\nHence Number is not Palindrome");
        }
    }
}
