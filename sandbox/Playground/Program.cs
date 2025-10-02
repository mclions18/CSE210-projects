using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Costume myCostume = new Costume();
        myCostume.outfit = "tartan and kilt";
        myCostume.footwear = "clogs";
        myCostume.tools = "bagpipes";
        Console.Write("What is you size? ");
        myCostume.size = Console.ReadLine();
        myCostume.Display();
    }
}