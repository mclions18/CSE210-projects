using System;
using System.ComponentModel.Design;

//To exceed expectations I created a method that will save and load a unique value for the amount of times an activity has been done, and display that value to the user at the end of an activity.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to the meditation room!\n");
            Console.Write("Please select from one of the following options:\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Exit\nSelection: ");
            string _selection = Console.ReadLine();
            if (_selection == "1")
            {

                Breathing breathing = new Breathing();
                breathing.Start();
            }
            else if (_selection == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.Start();
            }
            else if (_selection == "3")
            {
                Listing listing = new Listing();
                listing.Start();
            }
            else if (_selection == "4")
            {
                Console.WriteLine("\nThank you for joining us today! Please come back soon!\n");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid Selection...Please Try again");
            }
        }
    }
}