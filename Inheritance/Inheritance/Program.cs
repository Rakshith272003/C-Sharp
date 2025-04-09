using SingleInheritance;

namespace Inheritance
{
    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Animal");
            Animal.Run();
            Console.WriteLine("Single Inheritance");
            SingleInheritance.Person.Run();
            Console.WriteLine("MultiLevel Inheritance");
            MultilevelInheritance.Person.Run();
            Console.WriteLine("MultiLevel Inheritance");
            HierarchicalInheritance.Person.Run();   

        }
        

    }
    
}