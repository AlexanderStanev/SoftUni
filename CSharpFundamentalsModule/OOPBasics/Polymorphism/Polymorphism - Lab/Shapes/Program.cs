using System;

public class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(4);

        Console.WriteLine(circle.Draw());
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
    }
}
