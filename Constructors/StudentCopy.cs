using System;

namespace Constructors
{
    public class StudentCopy
    {
        string name;
        int age;

        
        public StudentCopy(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        
        public StudentCopy(StudentCopy existing)
        {
            this.name = existing.name;
            this.age = existing.age;
        }

        public void Display()
        {
            try
            {
                Console.WriteLine("StudentCopy:");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public static void Run()
        {
            StudentCopy student1 = new StudentCopy("Arjun", 20);
            StudentCopy student2 = new StudentCopy(student1); 

            Console.WriteLine("Original:");
            student1.Display();
            Console.WriteLine("Copied:");
            student2.Display();
        }
    }
}
