using System;

namespace HierarchicalInheritance
{
    public class Student : Person
    {
        private string course;

        public void GetStudentDetails()
        {
            GetPersonDetails();
            Console.WriteLine("Enter course:");
            course = Console.ReadLine();
        }

        public void ShowStudentDetails()
        {
            ShowPersonDetails();
            Console.WriteLine($"Course: {course}");
        }
    }
}
