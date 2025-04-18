using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
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
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Remove Student");
                Console.WriteLine("5. Update Student Name");
                Console.WriteLine("6.Sorting");
                Console.WriteLine("7. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:Classroom.AddStudent(); break;
                        case 2: Classroom.DisplayAllStudents(); break;
                    case 3:Classroom.SearchStudent();break;
                    case 4: Classroom.RemoveStudent(); break;
                    case 5: Classroom.UpdateStudent(); break;
                    case 6: Classroom.DisplaySortingOptions(); break;
                    case 7:
                    Console.WriteLine("exit!!!!");
                    Console.ReadKey();
                    exit = true;
                    break;
                default: Console.WriteLine("Ener valid choice"); break;


                }

                Console.WriteLine("----------------");
            }
        }
    }
}

    

