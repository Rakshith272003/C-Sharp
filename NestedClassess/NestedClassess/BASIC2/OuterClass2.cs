using System;
using NestedClassess.BASIC;

public class OuterClass2
{
    // Fields with different access modifiers
    private string privateField = "Private Field";
    protected string protectedField = "Protected Field";
    internal string internalField = "Internal Field";
    public string publicField = "Public Field";

    // Static fields
    private static string privateStaticField = "Private Static Field";
    public static string publicStaticField = "Public Static Field";

    // Methods with different access modifiers
    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected Method");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal Method");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public Method");
    }

    // Static methods
    private static void PrivateStaticMethod()
    {
        Console.WriteLine("Private Static Method");
    }

    public static void PublicStaticMethod()
    {
        Console.WriteLine("Public Static Method");
    }

    // Non-static nested class
    public class InnerClass
    {
        public void AccessOuterMembers()
        {
            OuterClass2 outer = new OuterClass2();

            // Accessing instance fields
            Console.WriteLine(outer.privateField);
            Console.WriteLine(outer.protectedField);
            Console.WriteLine(outer.internalField);
            Console.WriteLine(outer.publicField);

            // Accessing static fields
            Console.WriteLine(privateStaticField);
            Console.WriteLine(publicStaticField);

            // Accessing instance methods
            outer.PrivateMethod();
            outer.ProtectedMethod();
            outer.InternalMethod();
            outer.PublicMethod();

            // Accessing static methods
            PrivateStaticMethod();
            PublicStaticMethod();
        }
    }

    // Static nested class
    public static class StaticInnerClass
    {
        public static void AccessOuterMembers()
        {
            // Accessing static fields
            Console.WriteLine(privateStaticField);
            Console.WriteLine(publicStaticField);

            // Accessing static methods
            PrivateStaticMethod();
            PublicStaticMethod();

            // To access instance members, create an instance of OuterClass
            OuterClass2 outer = new OuterClass2();

            // Accessing instance fields
            Console.WriteLine(outer.privateField);
            Console.WriteLine(outer.protectedField);
            Console.WriteLine(outer.internalField);
            Console.WriteLine(outer.publicField);

            // Accessing instance methods
            outer.PrivateMethod();
            outer.ProtectedMethod();
            outer.InternalMethod();
            outer.PublicMethod();
        }

        
    }

    public static void Run()
    {
        OuterClass2.InnerClass inner = new OuterClass2.InnerClass();
        inner.AccessOuterMembers();

        Console.WriteLine();

        // Using static nested class
        OuterClass2.StaticInnerClass.AccessOuterMembers();
    }
}


