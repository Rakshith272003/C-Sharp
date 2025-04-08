namespace CalculatorApp.Modules
{
    public class Interest
    {
        public double Simple(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }

        public double Compound(double principal, double rate, double time, double n)
        {
            return principal * Math.Pow((1 + rate / (100 * n)), n * time) - principal;
        }
    }
}
