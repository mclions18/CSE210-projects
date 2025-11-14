using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Shape square = new Square("Red", 6);
        Shape rectangle = new Rectangle("Blue", 6, 8);
        Shape circle = new Circle("Green", 4);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($" This the shapes color and area: {s.GetColor()}, {s.GetArea()}");
        }
    }
}