using System;

// Define an interface
interface IVehicle
{
    void Start();
    void Stop();
}

// Implement the interface in a class
class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car has started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IVehicle myCar = new Car(); // Using interface reference
        myCar.Start();
        myCar.Stop();

        Console.ReadLine(); // Keeps the console window open
    }
}
