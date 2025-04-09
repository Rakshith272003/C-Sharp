namespace SingleInheritance
{
    public class Student : Person
    {
        private string course;
        private string college;

        public void GetStudentDetails()
        {
            GetDetails(); // from base class
            Console.WriteLine("Enter course:");
            course = Console.ReadLine();

            Console.WriteLine("Enter college:");
            college = Console.ReadLine();
        }

        public void ShowStudentDetails()
        {
            ShowDetails(); // from base class
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"College: {college}");
        }


    }
}
    

