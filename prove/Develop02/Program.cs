using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine(Environment.NewLine + "~~~" + Environment.NewLine + "What moments from today deserve a spot on the page?" + Environment.NewLine + "~~~" + Environment.NewLine);
        while (true)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load a journal");
            Console.WriteLine("4. Save a journal");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option (1-5): ");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                journal.Write();
            }
            else if (selection == 2)
            {
                journal.DisplayJournal();
            }
            else if (selection == 3)
            {
                journal.LoadFile();
            }
            else if (selection == 4)
            {
                journal.SaveFile();
            }
            else if (selection == 5)
            {
                journal.Quit();
            }
            else
            {
                Console.WriteLine("***" + Environment.NewLine + "Invalid Selection" + Environment.NewLine + "***");
            }
        }
    }
}


// Extra stuff: Ask about a goal they have for the next day to help them be productive, Display # of entires in the journel they have open