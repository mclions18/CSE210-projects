using System.Security.Cryptography;

public class Fraction
{
    //attributes
    private int _top;
    private int _bottom;

    //behaviors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public void SetTop()
    {
        Console.Write("What is the value for the Numerator? ");
        _top = int.Parse(Console.ReadLine());
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetBottom()
    {
        Console.Write("What is the value for the Denominator? ");
        _bottom = int.Parse(Console.ReadLine());
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double percent =  (double)_top /  (double)_bottom;
        return percent;
    }
}