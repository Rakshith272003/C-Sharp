using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Classroom
    {
        // Fixed the typo from 'studnet' to 'students'
        static Dictionary<int, string> students = new Dictionary<int, string>();

        // Method to add a student
        public static void AddStudent()
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Check if the ID or name already exists
            if (students.ContainsKey(id) || students.ContainsValue(name))
            {
                Console.WriteLine("ID or Name already exists.");
            }
            else
            {
                // Add student to the dictionary
                students.Add(id, name);
                Console.WriteLine("Student added successfully.");

                // Display all students
                foreach (KeyValuePair<int, string> student in students)
                {
                    Console.WriteLine($"{student.Key} - {student.Value}");
                }

                // Display total number of students
                Console.WriteLine("Total students: " + students.Count);
            }
        }

        // Method to remove a student by ID or name
        public static void RemoveStudent()
        {
            Console.WriteLine("Choose remove option:");
            Console.WriteLine("1. Remove by ID");
            Console.WriteLine("2. Remove by Name");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter ID to remove: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    // Check if the ID exists and remove it
                    if (students.ContainsKey(id))
                    {
                        students.Remove(id);
                        Console.WriteLine("Removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("ID not found.");
                    }
                    break;

                case 2:
                    Console.Write("Enter name to remove: ");
                    string name = Console.ReadLine();

                    // Find the first key for matching name
                    int keyToRemove = -1;
                    foreach (var student in students)
                    {
                        if (student.Value == name)
                        {
                            keyToRemove = student.Key;
                            break;
                        }
                    }

                    // Remove student if found by name
                    if (keyToRemove != -1)
                    {
                        students.Remove(keyToRemove);
                        Console.WriteLine("Removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Name not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        // Method to search for a student by ID or name
        public static void SearchStudent()
        {
            Console.WriteLine("Search by:");
            Console.WriteLine("1. ID");
            Console.WriteLine("2. Name");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Search by ID
                Console.Write("Enter student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (students.ContainsKey(id))
                {
                    Console.WriteLine($"Student Found: ID = {id}, Name = {students[id]}");
                }
                else
                {
                    Console.WriteLine("Student not found by that ID.");
                }
            }
            else if (choice == 2)
            {
                // Search by Name
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                bool found = false;
                foreach (var student in students)
                {
                    if (student.Value.ToLower() == name.ToLower())
                    {
                        Console.WriteLine($"Student Found: ID = {student.Key}, Name = {student.Value}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found by that name.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }


        public static void UpdateStudent()
        {
            Console.WriteLine("Enter the ID of the student you want to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.WriteLine($"Current Name: {students[id]}");
                Console.WriteLine("Enter the new name for the student: ");
                string newName = Console.ReadLine();

                // Update the student's name
                students[id] = newName;
                Console.WriteLine("Student updated successfully.");
                DisplayAllStudents();
            }
            else
            {
                Console.WriteLine("ID not found.");
            }
        }

        public static void DisplayAllStudents()
        {
            Console.WriteLine("\nAll Students:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
            Console.WriteLine("Total students: " + students.Count);
        }

        public static void DisplaySortingOptions()
        {
            Console.WriteLine("\nChoose Sorting Option:");
            Console.WriteLine("1. Sort by ID (Ascending)");
            Console.WriteLine("2. Sort by ID (Descending)");
            Console.WriteLine("3. Sort by Name (Ascending)");
            Console.WriteLine("4. Sort by Name (Descending)");

            int choice = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, string> sortedStudents = new Dictionary<int, string>();

            switch (choice)
            {
                case 1:
                    sortedStudents = students.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
                    Console.WriteLine("\nSorted by ID (Ascending):");
                    break;
                case 2:
                    sortedStudents = students.OrderByDescending(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
                    Console.WriteLine("\nSorted by ID (Descending):");
                    break;
                case 3:
                    sortedStudents = students.OrderBy(s => s.Value).ToDictionary(s => s.Key, s => s.Value);
                    Console.WriteLine("\nSorted by Name (Ascending):");
                    break;
                case 4:
                    sortedStudents = students.OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);
                    Console.WriteLine("\nSorted by Name (Descending):");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }
    }
}
