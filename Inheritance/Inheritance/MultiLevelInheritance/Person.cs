namespace MultilevelInheritance
{
    public class Person
    {
        protected string name;
        protected int age;

        public void GetPersonDetails()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowPersonDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

        public static void Run()
        {
            GraduateStudent graduateStudent = new GraduateStudent();
            graduateStudent.GetGraduateDetails();
            Console.WriteLine("Details of Graduate Students are");
            graduateStudent.ShowGraduateDetails();
        }

    }

}