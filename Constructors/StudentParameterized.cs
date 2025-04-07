using System;

namespace Constructors
{
    public class StudentParameterized
    {
        string name;
        int id;

        public StudentParameterized(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void Display()
        {
            Console.WriteLine("StudentParameterized:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
        }

        
        public static void Run()
        {
            StudentParameterized obj = new StudentParameterized("Rakshith", 101);
            obj.Display();
        }
    }
}
