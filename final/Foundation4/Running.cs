public class Running : Activity
{
    private double _distance;
    public Running(string d, double m, double dist):base(d,m)
    {
        _distance = dist;
    }
    public override double Speed()
    {
        return (_distance / _lengthMin) * 60;
    }
    public override double Pace()
    {
        return _lengthMin / _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine(_date + " " + GetActivityType() + $" ({_lengthMin} min):" + $"Distance: {_distance:F2} miles, " + $"Speed: {Speed():F2} mph, " + $"Pace: {Pace():F2} min/mile");
    }
}