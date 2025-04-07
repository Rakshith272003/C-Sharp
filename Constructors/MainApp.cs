
using System;

namespace Constructors
{
    class MainApp
    {
        static void Main(string[] args)
        {
            
            StudentDefault.Run();
            Console.WriteLine();
            StudentParameterized.Run();
            Console.WriteLine();
            StudentCopy.Run();
            Console.WriteLine();
            StudentStatic.Run();
            Console.ReadLine(); 
        }
    }
}
