using System;

// Abstract class
abstract class Payment

{   
    public abstract void Pay(double amount); // Abstract method
    
}

// Card Payment
class Card : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Card");
    }
}

// Cash Payment
class Cash : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Cash");
    }
}

// UPI Payment
class UPI : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");
    }
}

class Program
{
    static void Main()
    {
        Payment p1 = new Card();
        p1.Pay(500);

        Payment p2 = new Cash();
        p2.Pay(300);

        Payment p3 = new UPI();
        p3.Pay(250);

        //payment p4 = new payment();//this is not allowed it is not derived class
        //p4.pay(500);
    }
}
