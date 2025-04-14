


using System;

namespace EmployeeApp
{
    
    abstract class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public abstract void DisplayDetails();
    }

    class Employee : Person
    {
        public int EmployeeId;
        public string Department;
        public double Salary;
        public static string CompanyName;

        static Employee()
        {
            CompanyName = " Datalyzer ";
        }

        
        public Employee(string name, int age, string gender, int empId, string dept, double salary)
            : base(name, age, gender)
        {
            EmployeeId = empId;
            Department = dept;
            Salary = salary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
            Console.WriteLine($"EmpID: {EmployeeId}, Dept: {Department}, Salary: {Salary}, Company: {CompanyName}");
        }

        
        public void CalculateBonus()
        {
            Console.WriteLine("Bonus: " + (Salary * 0.1));
        }

        public void CalculateBonus(double percentage)
        {
            Console.WriteLine("Bonus: " + (Salary * percentage / 100));
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("RGM", 22, "Male", 101, "IT", 50000);
            emp.DisplayDetails();
            emp.CalculateBonus(); 
            emp.CalculateBonus(15); 
        }
    }
}