namespace MultilevelInheritance
{
    public class Student : Person
    {
        protected string course;
        protected string college;

        public void GetStudentDetails()
        {
            GetPersonDetails();
            Console.WriteLine("Enter course:");
            course = Console.ReadLine();

            Console.WriteLine("Enter college:");
            college = Console.ReadLine();
        }

        public void ShowStudentDetails()
        {
            ShowPersonDetails();
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"College: {college}");
        }
    }
}
   
