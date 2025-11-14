using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Square : Shape
{
    //attributes
    private double _side;

    //behaviors
    public Square(string c, double s):base(c)
    {
        _side = s;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}