using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nArmstrong numbers between {start} and {end} are:");

        for (int i = start; i <= end; i++)
        {
            if (IsArmstrong(i))
                Console.WriteLine(i);
        }
    }

    static bool IsArmstrong(int num)
    {
        int originalNum = num;
        int sum = 0;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
        }

        return sum == originalNum;
    }
}
