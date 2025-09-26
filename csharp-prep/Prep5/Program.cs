using System;
using System.Globalization;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int UserNumber = int.Parse(Console.ReadLine());
        return UserNumber;
    }

    static void PromptUserBirthYear(out int BirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        BirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int x)
    {
        int squared = x * x;
        return squared;
    }

    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");

        int agenow = 2025 - year;

        Console.WriteLine($"{name}, you will turn {agenow} this year.");
    }
    static void Main(string[] args)
    {
        int year;

        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        PromptUserBirthYear(out year);
        int sqaureFav = SquareNumber(favNumber);
        DisplayResult(userName, sqaureFav, year);
    }
}