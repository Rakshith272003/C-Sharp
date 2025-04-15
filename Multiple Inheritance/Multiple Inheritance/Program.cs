using System;

// First interface
interface IPrintable
{
    void Print();
}

// Second interface
interface IScannable
{
    void Scan();
}

// A class implementing both interfaces
class PrinterScanner : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PrinterScanner device = new PrinterScanner();

        device.Print(); // Calling Print method
        device.Scan();  // Calling Scan method

        Console.ReadLine(); // Keeps the console window open
    }
}
