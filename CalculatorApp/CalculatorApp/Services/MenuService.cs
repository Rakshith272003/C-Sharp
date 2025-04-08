namespace CalculatorApp.Services
{
    public class MenuService
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n====== Calculator Menu ======");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulus");
            Console.WriteLine("6. Simple Interest");
            Console.WriteLine("7. Compound Interest");
            Console.WriteLine("8. Exit");
            Console.Write("Select an option (1-8): ");
        }
    }
}
