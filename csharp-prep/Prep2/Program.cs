using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign = "";
        Console.Write("What was your grade percentage? ");
        string x = Console.ReadLine();
        int grade = int.Parse(x);
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int sign_check = grade % 10;

        if (sign_check >= 7 && grade < 90 && letter != "F")
        {
            sign = "+";
        }
        else if (sign_check < 3 && letter != "F" && grade != 100)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but with a bit of extra studying I know you can do it next time!");
        }
    }
}