using System;

namespace HierarchicalInheritance
{
    public class Person
    {
        protected string name;
        protected int age;

        public void GetPersonDetails()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowPersonDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
        public static void Run()
        {
            Console.WriteLine("Enter Student Details:");
            Student student = new Student();
            student.GetStudentDetails();

            Console.WriteLine("\nEnter Teacher Details:");
            Teacher teacher = new Teacher();
            teacher.GetTeacherDetails();

            Console.WriteLine("\nStudent Info:");
            student.ShowStudentDetails();

            Console.WriteLine("\nTeacher Info:");
            teacher.ShowTeacherDetails();

            
        }

        Console.ReadKey();
    }
}