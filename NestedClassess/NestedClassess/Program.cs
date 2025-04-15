using NestedClassess.BASIC;
using NestedClassess.BASIC1;

public class program
{
    public static void Main(string[] args)
    {
        OuterClass.Run();
        Console.WriteLine("Accessing Outer Class Members from a Nested Class");
        OuterClass1.Run();
        Console.WriteLine("Accessing Various Members from Nested Classes");
        OuterClass2.Run();

    }
}