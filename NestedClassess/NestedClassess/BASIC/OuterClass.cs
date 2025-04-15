using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassess.BASIC
{
    public class OuterClass
    {
       
        public void OuterMethod()
        {
            Console.WriteLine("This is the outer class method");
        }

        public class InnerClass
        {
            public void InnerMethod()
            {
                Console.WriteLine("This is the inner class method");
            }
        }

        public static void Run()
        {
            OuterClass outer = new OuterClass();
            outer.OuterMethod();

            OuterClass.InnerClass inner = new InnerClass();
            inner.InnerMethod();
        }

    }





    
}
