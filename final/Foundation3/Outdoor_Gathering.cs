public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string t, string d, string dt, string ti, Address a, string type, string w):base(t, d, dt, ti, a, type)
    {
        _weather = w;
    }
    public void Fulldetails()
    {
        Console.WriteLine($"{GetEVentType()} Event:");
        StandardDetails();
        Console.WriteLine($"The forcasted weather for the day is: {_weather}");
    }
}