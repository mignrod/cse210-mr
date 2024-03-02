using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            } 
            if (number > 0)
            {
                positiveNumbers.Add(number);

            }

        }
        int sum = numbers.Sum();
        float avg = ((float)sum ) / numbers.Count;
        int max = numbers.Max();

        int smallestNumber = positiveNumbers.Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine($"The sorted list is: ");

        numbers.Sort();
        foreach (int x in numbers)
        {
            Console.WriteLine(x);

        }

    }
}