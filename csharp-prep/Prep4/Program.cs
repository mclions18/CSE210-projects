using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.Write("Please enter a list of positive and negative numbers. (type '0' to stop): ");
        number = int.Parse(Console.ReadLine());

        do
        {
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
            Console.Write("Please enter another number: ");
            number = int.Parse(Console.ReadLine());
        } while (number != 0);

        float sum = 0;
        float average;
        int max;
        int min;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        average = sum / numbers.Count;
        max = numbers.Max();
        min = numbers.Where(i => i > 0).Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number greater than 0 is: {min}");
    }
}