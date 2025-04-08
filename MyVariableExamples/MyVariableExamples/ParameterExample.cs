using System;

public class ParameterExample
{
    public void Display(string message)
    {
        Console.WriteLine("Parameter Variable: " + message);
    }

    public static void Demo()
    {
        ParameterExample obj = new ParameterExample();
        obj.Display("Hello from parameter");
    }
}