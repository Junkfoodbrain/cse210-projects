using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Purple", 6));
        shapes.Add(new Rectangle("Red", 3, 5));
        shapes.Add(new Circle("Yellow", 2));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color={shape.GetColor()}, Area={shape.GetArea()}");
        }        
    }
}