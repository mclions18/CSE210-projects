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
            int selection = journal.MainMenu();
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