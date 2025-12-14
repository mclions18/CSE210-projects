public class Activity
{
    protected string _date;
    protected double _lengthMin;
    public Activity(string d, double m)
    {
        _date = d;
        _lengthMin = m;
    }
    public string GetActivityType()
    {
        return GetType().ToString();
    }
    public virtual double Distance()
    {
        return 0;
    }
    public virtual double Speed()
    {
        return 0;
    }
    public virtual double Pace()
    {
        return 0;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine("You shouldn't see this sentence.");
    }
}