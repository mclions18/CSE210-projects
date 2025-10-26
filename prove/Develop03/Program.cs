using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("James", 1, "5-6");
        Scripture scripture = new Scripture(reference, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");

        Console.Clear();
        Console.WriteLine("\nWelcome to the scripture memorizer!\n");
        while (true){
           Console.Write("Would you like to give your own scripture or use our preloaded verse (James 1:5-6)? (1 for preloaded verse, 2 for own scripture) ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                scripture.Display();
                Console.Write("\n\nPress enter to hide 3 words, type 'quit' to quit");
                string entry = Console.ReadLine();

                while (true)
                {
                    if (entry == "")
                    {
                        Console.Clear();
                        scripture.Hide();
                        scripture.Display();
                        Console.WriteLine("\n\nPress enter to hide 3 words, type 'quit' to quit");
                        entry = Console.ReadLine();
                    }
                    else if (entry == "quit")
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                }
                break;
            }
            else if (choice == "2")
            {
                Console.Write("What is the book? ");
                string book = Console.ReadLine();
                Console.Write("What is the chapter? ");
                int chapter = int.Parse(Console.ReadLine());
                Console.Write("What are the verse/verses?(ex. 5 or 4-7) ");
                string verses = Console.ReadLine();
                reference = new Reference(book, chapter, verses);
                Console.Write("What is the exact text of the verses you want to memorize? (Please type it in without the numbers between verese if there are multiple) ");
                string text = Console.ReadLine();
                scripture = new Scripture(reference, text);

                Console.Clear();
                scripture.Display();
                Console.Write("\n\nPress enter to hide 3 words, type 'quit' to quit");
                string entry = Console.ReadLine();

                while (true)
                {
                    if (entry == "")
                    {
                        Console.Clear();
                        scripture.Hide();
                        scripture.Display();
                        Console.WriteLine("\n\nPress enter to hide 3 words, type 'quit' to quit");
                        entry = Console.ReadLine();
                    }
                    else if (entry == "quit")
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("\nThat choice is invalid. Please try again.\n");
            } 
        }
    }
}