using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public class AtmOperations
    {
        public static void Withdraw(ATM atm)
        {
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();
            if (!atm.ValidatePin(pin))
            {
                Console.WriteLine("Incorrect PIN.");
                return;
            }

            Console.Write("Enter amount to withdraw: ₹");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine(atm.Withdraw(amount));
        }

        public static void Deposit(ATM atm)
        {
            Console.Write("Enter amount to deposit: ₹");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine(atm.Deposit(amount));
        }

        public static void CheckBalance(ATM atm)
        {
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();
            if (!atm.ValidatePin(pin))
            {
                Console.WriteLine("Incorrect PIN.");
                return;
            }

            Console.WriteLine(atm.CheckBalance());
        }

        public static void ChangePin(ATM atm)
        {
            Console.Write("Enter current PIN: ");
            string oldPin = Console.ReadLine();
            Console.Write("Enter new PIN: ");
            string newPin = Console.ReadLine();
            Console.WriteLine(atm.ChangePin(oldPin, newPin));
        }
    }
}
