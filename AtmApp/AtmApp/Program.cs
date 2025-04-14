using System;
using AtmApp;

namespace Atmapp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            ATM atm = new ATM("1234", 10000); 
            Console.WriteLine("Welcome to the ATM");

            try
            {
                while (true)
                {
                    AtmMenu.Show();
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AtmOperations.Withdraw(atm);
                            break;
                        case "2":
                            AtmOperations.Deposit(atm);
                            break;
                        case "3":
                            AtmOperations.CheckBalance(atm);
                            break;
                        case "4":
                            AtmOperations.ChangePin(atm);
                            break;
                        case "5":
                            Console.WriteLine("Thank you for using ATM. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice! Try again.");
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
