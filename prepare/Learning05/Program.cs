using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        List<shape> shapes = new List<shape>();
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}

internal class Circle
{
}