using System;

public class RefExample
{
    public void Modify(ref int value)
    {
        value += 5;
        Console.WriteLine("Ref Variable Modified to: " + value);
    }

    public static void Demo()
    {
        int refValue = 20;
        RefExample obj = new RefExample();
        obj.Modify(ref refValue);
    }
}