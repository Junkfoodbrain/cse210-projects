using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        Circle circle = new Circle("Green", 2);


        Console.WriteLine($"Square: color={square.GetColor()}, Area={square.GetArea()}");
        Console.WriteLine($"Rectangle: color={rectangle.GetColor()}, Area={rectangle.GetArea()}");
        Console.WriteLine($"Circle: Color={circle.GetColor()}, Area={circle.GetArea()}");
    }
}