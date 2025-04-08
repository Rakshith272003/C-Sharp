using System;

public class InstanceExample
{
    public string instanceVar = "I am an instance variable";

    public void Show()
    {
        Console.WriteLine("Instance Variable: " + instanceVar);
    }

    public static void Demo()
    {
        InstanceExample obj = new InstanceExample();
        obj.Show();
    }
}