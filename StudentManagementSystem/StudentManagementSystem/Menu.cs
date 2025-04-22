using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
  public class Menu
    {
        public static void MenuService()
        {
            Console.WriteLine("\n===== Student Manager =====");

            bool exit = false;
            while (!exit) 
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Multiple Students");
                Console.WriteLine("3. Insert Student at Specific Index");
                Console.WriteLine("4. Display All Students");
                Console.WriteLine("5. Search Student");
                Console.WriteLine("6. Remove Student");
                Console.WriteLine("7. Sort Students Alphabetically");
                //Console.WriteLine("8. Reverse Student List");
                //Console.WriteLine("9. Show Count and Capacity");
                //Console.WriteLine("10. Convert to Array");
                //Console.WriteLine("11. Clear All Students");
                Console.WriteLine("8. Exit");

                int choice = int.Parse(Console.ReadLine());

#if true
                switch (choice)
                {
                    case 1: Classroom.AddStudent(); break;
                    case 2: Classroom.AddMultipleStudents(); break;
                    case 3: Classroom.AddAtIndex(); break;
                    case 4: Classroom.Show(); break;
                    case 5: Classroom.SearchStudent(); break;
                    case 6: Classroom.RemoveStudent(); break;
                    case 7: Classroom.SortAlphabetically(); break;
                    case 8:
                        Console.WriteLine("exit!!!!");
                        Console.ReadKey();
                        exit = true;
                        break;
                    default: Console.WriteLine("Ener valid choice"); break;

#endif

                }

            }
        }
    }
}
