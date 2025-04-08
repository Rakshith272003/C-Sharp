using System;

public class StaticExample
{
    public static int count = 0;

    public void Increment()
    {
        count++;
        Console.WriteLine("Static Variable (shared): " + count);
    }

    public static void Demo()
    {
        StaticExample obj1 = new StaticExample();
        StaticExample obj2 = new StaticExample();
        obj1.Increment();
        obj2.Increment();
    }
}