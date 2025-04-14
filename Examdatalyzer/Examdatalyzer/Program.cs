class Program
{
    static void Main(string[] args)
    {
        Manager ma = new Manager("RGM", 22, "Male", 101, "IT", 50000,5,"Project Manager");
        ma.DisplayDetails();
        ma.CalculateBonus();
        ma.CalculateBonus(15);
        Manager.ManagerDisplayDetails();

    }
}