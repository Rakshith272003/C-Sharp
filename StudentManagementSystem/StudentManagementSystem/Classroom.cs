using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> TeacherInfo { get; set; }
    }
     public class Classroom
    {
        static public List<Student> _studentData = new List<Student>();
        static List<string> students = new List<string>();
        public string name;
        public static void AddStudent()
        {
            try
            {
                Console.Write("Enter student name to add: ");
                string name = Console.ReadLine();
                students.Add(name);
                Console.WriteLine("Student added!");
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void AddMultipleStudents()
        {
            try
            {
                Console.Write("How many students do you want to add? ");
                int count = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter name {i + 1}: ");
                    string name = Console.ReadLine();
                    students.Add(name);

                }
                Console.WriteLine("Students added"!);
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void AddAtIndex()
        {
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Student student = new Student();
                    Console.Write("Enter student name to add at specific index: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Enter student Id to add at specific index: ");
                    student.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter No of Teachers to add at specific index: ");
                    student.TeacherInfo = new List<Teacher>();
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j <= count; j++)
                    {
                        Teacher teacher = new Teacher();
                        Console.Write("Enter Teacher name to add at specific index: ");
                        teacher.Name = Console.ReadLine();

                        Console.Write("Enter Teacher Desc to add at specific index: ");
                        teacher.Description = Console.ReadLine();

                        student.TeacherInfo.Add(teacher);

                    }

                    _studentData.Add(student);

                }
                //Console.Write("Enter student name to add at specific index: ");
                //string name = Console.ReadLine();
                //Console.WriteLine("Enter the index to add the name");
                //int index = Convert.ToInt32(Console.ReadLine());
                //students.Insert(index, name);
                //Console.WriteLine("Student added!");
                //foreach (string student in students)
                //{
                //    Console.WriteLine(student);
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void Show()
        {
            foreach (string student in students)
            {
                Console.WriteLine(student);

            }
        }

        public static void SearchStudent()
        {
            try
            {
                Console.WriteLine("enter the name to find");
                string name = Console.ReadLine();
                Console.WriteLine(students.Contains(name));
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void RemoveStudent()
        {

            Console.WriteLine("Enter the whichtype option u need to remove the name");

            Console.WriteLine("1. remove(name)");
            Console.WriteLine("2. removeAt(Index)");
            Console.WriteLine("3. removeRange(index,count)"); 

            int removech = Convert.ToInt32(Console.ReadLine());

            try
            {



                switch (removech)
                {
                    case 1:
                        Console.WriteLine("Enter the name u want to remove");
                        string name = Console.ReadLine();
                        Console.WriteLine(students.Remove(name));
                        Console.WriteLine(name + "Removed Succesfully");
                        foreach (string student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the index at which u want to remove");
                        int index1 = Convert.ToInt32(Console.ReadLine());
                        students.RemoveAt(index1);
                        Console.WriteLine(index1 + "Removed Succesfully");
                        foreach (string student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;

                    case 3:
                        Console.WriteLine("it will remove all");
                        students.Clear();
                        foreach (string student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    default: Console.WriteLine("Invalid choice"); break;

                }

            }
            catch (Exception)
            {

                throw;
            }

            }

        

        public static void SortAlphabetically()
        {
#if true
            Console.WriteLine("Sorting names alphabetically...");
            students.Sort(); // Sorts in-place

            Console.WriteLine("Sorted List:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            } 
#endif
        }




    }

}

