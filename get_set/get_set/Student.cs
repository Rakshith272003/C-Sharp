namespace get_set
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public string course { get; set; }

        public void display()
        {
            Console.WriteLine($"ID:{id}"); 
            Console.WriteLine($"NAME:{name}");
            Console.WriteLine($"AGE:{age}");
            Console.WriteLine($"COURSE:{course}");
        }
        public static void run()
        {
            Student student = new Student();
            student.id = 12;//Convert.ToInt32(Console.ReadLine());
            student.name = "Rakshith";
            student.age = 22;
            student.course = "CSE";
            student.display();
        }

    }
}