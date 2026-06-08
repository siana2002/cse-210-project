using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapesList = new List<Shape>();

        Square square = new Square("blue", 5);
        _shapesList.Add(square);

        Rectangle rectangle = new Rectangle("red",10, 10);
        _shapesList.Add(rectangle);

        Circle circle = new Circle("Black", 2);
        _shapesList.Add(circle);

       foreach (Shape shape in _shapesList)
        {
            double area = shape.GetArea();

            Console.WriteLine($"The {shape} shape has an area of {area}. ");
        }
    }
}