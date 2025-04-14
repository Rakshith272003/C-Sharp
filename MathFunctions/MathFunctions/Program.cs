using System;

class Program
{
    static void Main()
    {
        double a = -7.5;
        double b = 4.2;
        double c = 100;

        Console.WriteLine("=== Math Functions Demo ===");

        // Absolute value
        Console.WriteLine("Abs(-7.5): " + Math.Abs(a));

        // Square Root
        Console.WriteLine("Sqrt(4.2): " + Math.Sqrt(b));

        // Power
        Console.WriteLine("Pow(2, 3): " + Math.Pow(2, 3));

        // Round
        Console.WriteLine("Round(4.6): " + Math.Round(4.6));

        // Floor
        Console.WriteLine("Floor(4.6): " + Math.Floor(4.6));

        // Ceiling
        Console.WriteLine("Ceiling(4.2): " + Math.Ceiling(4.2));

        // Max
        Console.WriteLine("Max(4.2, -7.5): " + Math.Max(b, a));

        // Min
        Console.WriteLine("Min(4.2, -7.5): " + Math.Min(b, a));

        // Natural Log
        Console.WriteLine("Log(100): " + Math.Log(c));

        // Log base 10
        Console.WriteLine("Log10(100): " + Math.Log10(c));

        // Exp (e^x)
        Console.WriteLine("Exp(1): " + Math.Exp(1));

        // Truncate
        Console.WriteLine("Truncate(-7.5): " + Math.Truncate(a));

        // Sign
        Console.WriteLine("Sign(-7.5): " + Math.Sign(a));
        Console.WriteLine("Sign(0): " + Math.Sign(0));
        Console.WriteLine("Sign(4.2): " + Math.Sign(b));

        // Trigonometric
        Console.WriteLine("Sin(PI/2): " + Math.Sin(Math.PI / 2));
        Console.WriteLine("Cos(0): " + Math.Cos(0));
        Console.WriteLine("Tan(PI/4): " + Math.Tan(Math.PI / 4));

        // Constants
        Console.WriteLine("PI: " + Math.PI);
        Console.WriteLine("E: " + Math.E);

        // Atan, Asin, Acos
        Console.WriteLine("Atan(1): " + Math.Atan(1));      
        Console.WriteLine("Asin(1): " + Math.Asin(1));      
        Console.WriteLine("Acos(1): " + Math.Acos(1));      

        // Hyperbolic functions
        Console.WriteLine("Sinh(1): " + Math.Sinh(1));
        Console.WriteLine("Cosh(1): " + Math.Cosh(1));
        Console.WriteLine("Tanh(1): " + Math.Tanh(1));
    }
}
