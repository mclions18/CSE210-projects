public class Rectangle : Shape
{
    //attributes
    private double _length;
    private double _width;

    //behaviors
    public Rectangle(string c, double l, double w) : base(c)
    {
        _length = l;
        _width = w;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}