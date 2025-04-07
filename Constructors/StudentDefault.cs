using System;

namespace Constructors
{
    public class StudentDefault
    {
        string name;
        int id;

        public StudentDefault()
        {
            this.name = "Default Name";
            this.id = 0;
        }

        public void Display()
        {
            Console.WriteLine("StudentDefault:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
        }

        
        public static void Run()
        {
            StudentDefault obj = new StudentDefault();
            obj.Display();
        }
    }
}
