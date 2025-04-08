using CalculatorApp.Modules;

namespace CalculatorApp.Services
{
    public class InterestService
    {
        public static void CalculateSimpleInterest()
        {
            Interest interest = new Interest();

            Console.Write("Enter Principal: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate (%): ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Enter Time (years): ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine($"Simple Interest = {interest.Simple(p, r, t)}");
        }

        public static void CalculateCompoundInterest()
        {
            Interest interest = new Interest();

            Console.Write("Enter Principal: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate (%): ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Enter Time (years): ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Enter Compounding Frequency per year: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine($"Compound Interest = {interest.Compound(p, r, t, n)}");
        }
    }
}
