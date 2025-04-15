using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Accessing Outer Class Members from Inner Class

namespace NestedClassess.BASIC1
{
   public class OuterClass1
    {
        private string privateField = "Private Field";
        protected string protectedField = "Protected Field";
        internal string internalField = "Internal Field";
        public string publicField = "Public Field";


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

        public class InnerClass1
        {
            public void AccesOuterMembers()
            {
                OuterClass1 outer = new OuterClass1();

                // Accessing fields
                Console.WriteLine(outer.privateField);
                Console.WriteLine(outer.protectedField);
                Console.WriteLine(outer.internalField);
                Console.WriteLine(outer.publicField);

                // Accessing methods
                outer.PrivateMethod();
                outer.ProtectedMethod();
                outer.InternalMethod();
                outer.PublicMethod();
            }
        }

        public static void Run()
            {
                OuterClass1.InnerClass1 nested = new OuterClass1.InnerClass1();
                nested.AccesOuterMembers();
                
            }


           
           

           
            
        
    }
}
