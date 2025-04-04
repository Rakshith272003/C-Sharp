using System.Numerics;

namespace Datatypes
{
    public class Student
    {
        public int id;
        public string name; 
        public int age;
        public float m1;
        public float m2;
        public float m3;
        public float avgof3;

        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"ID      : {id}");
            Console.WriteLine($"Name    : {name}");
            Console.WriteLine($"Age     : {age}");
            Console.WriteLine($"Marks 1 : {m1}");
            Console.WriteLine($"Marks 2 : {m2}");
            Console.WriteLine($"Marks 3 : {m3}");
            Console.WriteLine($"Average : {avgof3}");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Enter the id ");
            s.id= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the name");
            s.name = Console.ReadLine();
            
            Console.WriteLine("Enter the age");
            s.age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the marks m1");
            s.m1=float.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the marks m2");
            s.m2 =float.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the marks m3");
            s.m3 =float.Parse(Console.ReadLine());
            s.avgof3 = (s.m1+s.m2+s.m3)/3f;

            s.DisplayDetails();

        }
    }
}
