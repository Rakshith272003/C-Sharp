using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public delegate void Notification (string message); 

public class NotiificationsDemo
{
    public static void Email(string msg)
    {
        Console.WriteLine(msg + " Email Msg");
    }
    public static void SMS(string msg)
    {
        Console.WriteLine(msg + " SMS Message");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Notification notify = new Notification(NotiificationsDemo.Email);
        notify += NotiificationsDemo.SMS;
        notify("Hi");
    }
}