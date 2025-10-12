using System.ComponentModel.DataAnnotations;

class Entry
{
    // atributes
    public string _date = "";
    public string _prompt = "";
    public string _promptResponse = "";
    public string _goalResponse = "";

    // behaviors
    public void Display()
    {
        Console.WriteLine("~~~~~~~~~~");
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"{_promptResponse}");
        Console.WriteLine($"Productivity goal for tomorrow: {_goalResponse}");
        Console.WriteLine("~~~~~~~~~~" + Environment.NewLine);
    }
}