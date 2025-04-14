using EmployeeApp;
using System.Reflection;
using System.Xml.Linq;

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


    public virtual void CalculateBonus()
    {
        Console.WriteLine("Bonus: " + (Salary * 0.1));
    }

    public void CalculateBonus(double percentage)
    {
        Console.WriteLine("Bonus: " + (Salary * percentage / 100));
    }
}