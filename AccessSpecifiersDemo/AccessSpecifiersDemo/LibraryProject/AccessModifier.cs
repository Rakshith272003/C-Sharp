using System;

namespace LibraryProject
{
    public class BaseClass
    {
        private string privateVar = "Private";
        public string publicVar = "Public";
        protected string protectedVar = "Protected";
        internal string internalVar = "Internal";
        protected internal string protectedInternalVar = "Protected Internal";
        private protected string privateProtectedVar = "Private Protected";

        public void TestAccessInSameClass()
        {
            Console.WriteLine("From Same Class:");
            Console.WriteLine(privateVar);
            Console.WriteLine(publicVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(privateProtectedVar);
        }
    }

    public class DerivedInSameAssembly : BaseClass
    {
        public void Test()
        {
            Console.WriteLine("From Derived Class in Same Assembly:");
            //Console.WriteLine(privateVar);// not accesible outside the class or derived class            
            Console.WriteLine(publicVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(privateProtectedVar);
        }
    }
}