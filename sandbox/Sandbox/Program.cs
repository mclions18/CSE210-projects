using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string hello = "hello sandbox world!!!";
        TextInfo textinfo = CultureInfo.CurrentCulture.TextInfo;
        string Capitalized = textinfo.ToTitleCase(hello);
        Console.WriteLine(Capitalized);
    }
}