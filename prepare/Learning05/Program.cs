using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Red", 2);
        string color = square1.GetColor();
        double area = square1.GetArea();
        Console.WriteLine($"The color shape is {color}, and has an area of {area}.");

        // Creating a list of shapes to store differents shapes.
        List<Shape> shapes = new List<Shape>();

        // Adding the shapes
        Square fig1  = new Square("Yellow", 3);
        shapes.Add(fig1);

        Rectangle fig2 = new Rectangle("Blue", 4, 3);
        shapes.Add(fig2);

        Circle fig3 = new Circle("Purple", 5);
        shapes.Add(fig3);

        // Iterate through the list
        foreach(Shape shape in shapes)
        {
            color = shape.GetColor();
            area = shape.GetArea();

            Console.WriteLine($"The color shape is {color}, and has an area of {area}.");

        }

    }
}