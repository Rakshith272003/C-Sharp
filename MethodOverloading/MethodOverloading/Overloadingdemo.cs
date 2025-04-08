using System.Security.Cryptography;

namespace MethodOverloading
{
    class Overloadingdemo
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int add(int a,int b,int c)
        {
            return a + b + c;
        }
        
        public static void demo()
        {
            Overloadingdemo od = new Overloadingdemo();
            Console.WriteLine(od.add(1,2));
            Console.WriteLine(od.add(2,3));
            Console.WriteLine(od.add(3,4));
            Console.WriteLine(od.add(4,5));
            Console.WriteLine(od.add(5,6,7));
        }
    }
}