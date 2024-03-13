using System;

class Program
{
    static void Main(string[] args)
    {
        // Prove for the first fraction with get and set methods
        Fractions f0 = new Fractions();
        f0.SetTop(3);
        f0.SetBottom(2);
        Console.WriteLine(f0.GetFractionString());
        Console.WriteLine(f0.GetDecimalValue());
        Console.WriteLine(f0.GetTop());
        Console.WriteLine(f0.GetBottom());
        Console.WriteLine("<<<<<<<<<<<<<<>>>>>>>>>>>>>>>");

        Fractions f1 = new Fractions();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fractions f2 = new Fractions(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fractions f3 = new Fractions(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fractions f4 = new Fractions(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}