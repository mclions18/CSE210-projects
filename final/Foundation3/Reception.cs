public class Reception : Event
{
    private string _rsvp;
    public Reception(string t, string d, string dt, string ti, Address a, string type, string rsvp):base(t, d, dt, ti, a, type)
    {
        _rsvp = rsvp;
    }
    public void Fulldetails()
    {
        Console.WriteLine($"{GetEVentType()} Event:");
        StandardDetails();
        Console.WriteLine($"To RSVP please email: {_rsvp}");
    }
}