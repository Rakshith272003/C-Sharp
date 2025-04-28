public delegate void ShowMessage(string message);

public class DemoClass
{
    public static void Demo(string msg)
    {
        Console.WriteLine("Message Recived:"+msg);
    }
}

class Program {
    public static void Main(string[] args)
    {
        ShowMessage shw = new ShowMessage(DemoClass.Demo);
        shw("hi message from delegates");
    }
}
    

