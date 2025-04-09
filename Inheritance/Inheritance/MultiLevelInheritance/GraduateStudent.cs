namespace MultilevelInheritance
{
    public class GraduateStudent : Student
    {
        private string specialization;

        public void GetGraduateDetails()
        {
            GetStudentDetails();
            Console.WriteLine("Enter specialization:");
            specialization = Console.ReadLine();
        }

        public void ShowGraduateDetails()
        {
            ShowStudentDetails();
            Console.WriteLine($"Specialization: {specialization}");
        }
    }
}