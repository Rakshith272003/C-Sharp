using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
     public class Classroom
    {
        static List<string> students = new List<string>();
        public string name;
        public static void AddStudent()
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

        public static void AddMultipleStudents()
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


        public static void AddAtIndex()
        {
            Console.Write("Enter student name to add at specific index: ");
            string name= Console.ReadLine();
            Console.WriteLine("Enter the index to add the name");
            int index=Convert.ToInt32(Console.ReadLine());
            students.Insert(index, name);
            Console.WriteLine("Student added!");
            foreach (string student in students)
            {
                Console.WriteLine(student);
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
            Console.WriteLine("enter the name to find");
            string name = Console.ReadLine();
            Console.WriteLine(students.Contains(name));
        }


        public static void RemoveStudent()
        {

            Console.WriteLine("Enter the whichtype option u need to remove the name");

            Console.WriteLine("1. remove(name)");
            Console.WriteLine("2. removeAt(Index)");
            Console.WriteLine("3. removeRange(index,count)"); 

            int removech = Convert.ToInt32(Console.ReadLine());

            


                switch (removech)
                {
                    case 1: Console.WriteLine("Enter the name u want to remove");
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
                    default:Console.WriteLine("Invalid choice"); break;
                         
                }


            }

        

        public static void SortAlphabetically()
        {
            Console.WriteLine("Sorting names alphabetically...");
            students.Sort(); // Sorts in-place

            Console.WriteLine("Sorted List:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }




    }

}

