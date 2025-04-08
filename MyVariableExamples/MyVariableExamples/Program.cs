using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Variable Types Demo\n");

        LocalExample.Demo();
        InstanceExample.Demo();
        StaticExample.Demo();
        ConstExample.Demo();
        ReadonlyExample.Demo();
        ParameterExample.Demo();
        RefExample.Demo();
        OutExample.Demo();
        Globals.Demo();
    }
}