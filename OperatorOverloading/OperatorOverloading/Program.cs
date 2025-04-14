class Program
{
    static void Main()
    {
        Number a = new Number(10);
        Number b = new Number(5);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("\nAddition (a + b): " + (a + b));
        Console.WriteLine("Subtraction (a - b): " + (a - b));
        Console.WriteLine("Multiplication (a * b): " + (a * b));
        Console.WriteLine("Division (a / b): " + (a / b));

        Console.WriteLine("\nEquality (a == b): " + (a == b));
        Console.WriteLine("Inequality (a != b): " + (a != b));

        Console.WriteLine("Greater Than (a > b): " + (a > b));
        Console.WriteLine("Less Than (a < b): " + (a < b));
        Console.WriteLine("Greater or Equal (a >= b): " + (a >= b));
        Console.WriteLine("Less or Equal (a <= b): " + (a <= b));

        Console.WriteLine("\nIncrement (++a): " + (++a));
        Console.WriteLine("Decrement (--b): " + (--b));

        Number zero = new Number(0);
        Console.WriteLine("\nLogical Not (!zero): " + (!zero)); 
        Console.WriteLine("Logical Not (!a): " + (!a)); 
    }
}
