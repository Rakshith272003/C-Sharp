using System;

public class OutExample
{
    public void GetValue(out int val)
    {
        val = 100;
        Console.WriteLine("Out Variable Set to: " + val);
    }

    public static void Demo()
    {
        int outValue;
        OutExample obj = new OutExample();
        obj.GetValue(out outValue);
    }
}