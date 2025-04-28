// Program to demonstrate an Application (Custom) Exception
using System;

namespace ApplicationExceptionDemo
{
    // Creating a custom exception by inheriting from Exception class
    public class MyApplicationException : Exception
    {
        public MyApplicationException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Exception Example - Custom Exception\n");

            try
            {
                throw new MyApplicationException("Custom error occurred in the application!");
            }
            catch (MyApplicationException ex)
            {
                Console.WriteLine("Caught Application Exception:");
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.WriteLine("\nProgram continues after exception handling.");
        }
    }
}
