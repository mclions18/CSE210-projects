public class Circle : Shape
{
    //attributes
    private double _radius;

    //behaviors
    public Circle(string c, double r) : base(c)
    {
        _radius = r;
    }
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}