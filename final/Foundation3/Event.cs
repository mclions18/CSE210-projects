using System.Dynamic;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;
    public Event(string t, string d, string dt, string ti, Address a, string type)
    {
        _title = t;
        _description = d;
        _date = dt;
        _time = ti;
        _address = a;
        _type = type;
    }
    public void ShortDescription()
    {
        Console.WriteLine($"{_type} Event: {_title} - {_date}");
    }
    public void StandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} - {_time}");
        _address.Stringified();
    }
    public string GetEVentType()
    {
        return _type;
    }
}