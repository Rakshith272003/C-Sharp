using LibraryProject;
using System;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
            DerivedInSameAssembly derived = new DerivedInSameAssembly();

            Console.WriteLine("From MainProject:");
            // Console.WriteLine(obj.privateVar);        
            Console.WriteLine(obj.publicVar);
            // Console.WriteLine(obj.protectedVar);      
            Console.WriteLine(obj.internalVar);
            Console.WriteLine(obj.protectedInternalVar);
            // Console.WriteLine(obj.privateProtectedVar); 
            derived.Test();
        }
    }
}