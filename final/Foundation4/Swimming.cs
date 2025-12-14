public class Swimming : Activity
{
    private double _laps;
    public Swimming(string d, double m, double l) : base(d, m)
    {
        _laps = l;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double Speed()
    {
        return (Distance() / _lengthMin) * 60;
    }
    public override double Pace()
    {
        return _lengthMin / Distance();
    }
    public override void GetSummary()
    {
        Console.WriteLine(_date + " " + GetActivityType() + $" ({_lengthMin} min):" + $"Distance: {Distance():F2} miles, " + $"Speed: {Speed():F2} mph, " + $"Pace: {Pace():F2} min/mile");
    }
}