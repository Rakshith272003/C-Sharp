// Program to demonstrate a System Exception
using System;

namespace SystemExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System Exception Example - Division by Zero\n");

            try
            {
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator; // Causes DivideByZeroException
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught System Exception:");
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.WriteLine("\nProgram continues after exception handling.");
        }
    }
}
