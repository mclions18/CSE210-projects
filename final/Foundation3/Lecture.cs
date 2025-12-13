public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string t, string d, string dt, string ti, Address a, string type, string speak, int cap):base(t, d, dt, ti, a, type)
    {
        _speaker = speak;
        _capacity = cap;
    }
    public void Fulldetails()
    {
        Console.WriteLine($"{GetEVentType()} Event:");
        Console.WriteLine(_speaker);
        StandardDetails();
        Console.WriteLine($"Capacity: {_capacity}");
    }
}