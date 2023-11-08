using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 5.0, 7.0));
        shapes.Add(new Circle("Yellow", 5.0));

        foreach (Shape shape in shapes)
        {
            string _color = shape.GetColor();
            double _area = shape.GetArea();

            Console.WriteLine($"The {_color} shape has an area of: {_area}");
        }
        
    }
}