using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
            Console.WriteLine($"Current number: {number}, Running sum: {sum}");
        }

        Console.WriteLine($"Total Sum: {sum}");
    }
}