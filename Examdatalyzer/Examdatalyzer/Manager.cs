class Manager : Employee
{
    static int teamsize;
    static string role;
    public Manager(string name, int age, string gender, int empId, string dept, double salary,int teamsize,string role)
        : base(name,age,gender,empId,dept,salary)
    {
        teamsize = teamsize;
        role = role;
    }
    public override void CalculateBonus()
    {
        Console.WriteLine("Bonus: " + (Salary * 0.5));
    }
    public static void ManagerDisplayDetails()
    {
        
        Console.WriteLine($"TeamSize: {teamsize}, Role: {role}");

    }

}