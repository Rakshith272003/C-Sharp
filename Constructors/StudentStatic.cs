using System;

namespace Constructors
{
    public class StudentStatic
    {
        static string universityName;
        string studentName;
        int rollNumber;

        
        static StudentStatic()
        {
            universityName = "VTU University";
            Console.WriteLine("Static Constructor called");
        }

        public StudentStatic(string name, int roll)
        {
            studentName = name;
            rollNumber = roll;
        }

        public void Display()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("University: " + universityName);
        }

        
        public static void Run()
        {
            StudentStatic s1 = new StudentStatic("Rakshith", 13);
            StudentStatic s2 = new StudentStatic("Akhil", 21);
            s1.Display();
            Console.WriteLine();
            s2.Display();
        }
    }
}
