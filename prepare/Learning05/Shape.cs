using System.Drawing;

public class Shape
{
    //attributes
    private string _color;

    //behaviors
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string c)
    {
        _color = c;
    }
    public virtual double GetArea()
    {
        Console.WriteLine("If you are seeing this message, I did something wrong.");
        return 0;
    }
}