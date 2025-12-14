public class Cycling : Activity
{
    private double _speed;
    public Cycling(string d, double m, double s) : base(d, m)
    {
        _speed = s;
    }
    public override double Distance()
    {
        return (_speed / 60) * _lengthMin;
    }
    public override double Pace()
    {
        return _lengthMin / Distance();
    }
    public override void GetSummary()
    {
        Console.WriteLine(_date + " " + GetActivityType() + $" ({_lengthMin} min):" + $"Distance: {Distance():F2} miles, " + $"Speed: {_speed:F2} mph, " + $"Pace: {Pace():F2} min/mile"); 
    }
}