namespace SingleInheritance 
{ 
    public class Person {

        protected string name;
        protected int age;

        public void GetDetails()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
    }
        public static void Run()
        {
            Student student = new Student();
            student.GetStudentDetails();
            Console.WriteLine("\n--- Student Information ---");
            student.ShowStudentDetails();
        }
    }
}
