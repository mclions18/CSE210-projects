using System.ComponentModel.Design;
using System.IO.Compression;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    // attributes
    public List<Entry> _entryList = new List<Entry>();
    public List<string> _promptOptions = new List<string> { "What’s one moment from today that you want to remember?", "What emotion lingered with you most today and why do you think it stayed?", "What’s one thing you learned — about yourself, someone else, or life — today?", "What went better than you expected today?", "Who or what made you feel grateful today?", "If you could send a short note to your morning self, what would it say?", "What was a small victory you had today?" };

    // behaviors
    public int MainMenu()
    {
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal entries");
        Console.WriteLine("3. Load a journal");
        Console.WriteLine("4. Save a journal");
        Console.WriteLine("5. Quit");
        Console.Write("Please select an option (1-5): ");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }
    public void Write()
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        Random random = new Random();
        int promptSelect = random.Next(0, _promptOptions.Count - 1);

        entry._prompt = _promptOptions[promptSelect];
        Console.Write($"{entry._prompt}");
        entry._promptResponse = Console.ReadLine();
        Console.Write("What goal do you have for tomorrow to be productive? ");
        entry._goalResponse = Console.ReadLine();
        _entryList.Add(entry);
    }
    public void DisplayJournal()
    {
        int entries = _entryList.Count;
        Console.WriteLine(Environment.NewLine + $"Number of Entries: {entries}" + Environment.NewLine);
        foreach (Entry i in _entryList)
        {
            i.Display();
        }
    }
    public void LoadFile()
    {
        _entryList = new List<Entry>();
        Console.Write("What is the file name?(.csv) ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._promptResponse = parts[2];
            entry._goalResponse = parts[3];
            _entryList.Add(entry);
        }
        Console.WriteLine(Environment.NewLine + "File Loaded" + Environment.NewLine);
    }
    public void SaveFile()
    {
        Console.Write("What is the file name?(.csv) ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry i in _entryList)
            {
                writer.WriteLine($"{i._date}|{i._prompt}|{i._promptResponse}|{i._goalResponse}");
            }
        }

    }
    public void Quit()
    {
        Console.Write("Goodbye!");
        Environment.Exit(0);
    }
}

