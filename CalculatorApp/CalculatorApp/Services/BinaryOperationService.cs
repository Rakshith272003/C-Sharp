using CalculatorApp.Modules;

namespace CalculatorApp.Services
{
    public class BinaryOperationsService
    {
        public static void HandleOperation(int operationType)
        {
            Calculator calc = new Calculator();

            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            double result = operationType switch
            {
                1 => calc.Add(a, b),
                2 => calc.Subtract(a, b),
                3 => calc.Multiply(a, b),
                4 => calc.Divide(a, b),
                5 => calc.Modulus(a, b),
                _ => throw new InvalidOperationException("Unknown operation.")
            };

            Console.WriteLine($"Result: {result}");
        }
    }
}
