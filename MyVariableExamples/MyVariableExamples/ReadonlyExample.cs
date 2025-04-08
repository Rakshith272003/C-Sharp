using System;

public class ReadonlyExample
{
    public readonly string name;

    public ReadonlyExample()
    {
        name = "I am readonly";
    }

    public void Show()
    {
        Console.WriteLine("Readonly Variable: " + name);
    }

    public static void Demo()
    {
        ReadonlyExample obj = new ReadonlyExample();
        obj.Show();
    }
}