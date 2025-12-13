public class Address
{
    private string _city;
    private string _state;
    private string _locationName;
    public Address(string c, string s, string l)
    {
        _city = c;
        _state = s;
        _locationName = l;
    }
    public void Stringified()
    {
        Console.WriteLine($"{_locationName}\n{_city}, {_state}"); 
    }
}