using System;

namespace HierarchicalInheritance
{
    public class Teacher : Person
    {
        private string subject;

        public void GetTeacherDetails()
        {
            GetPersonDetails();
            Console.WriteLine("Enter subject:");
            subject = Console.ReadLine();
        }

        public void ShowTeacherDetails()
        {
            ShowPersonDetails();
            Console.WriteLine($"Subject: {subject}");
        }
    }
}
