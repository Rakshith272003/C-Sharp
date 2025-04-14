using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Atm
    {
        private double _balance = 10000;
        private string _pin = "1234";

        public string WithDraw(double _ammount, string _enteredpin)
        {
            if(_enteredpin != _pin)
            {
                return "Inccorect Pin";
            }
            if(_ammount > _balance)
            {
                return "Insuffiecent Balance";
            }
            _balance -= _ammount;
            return $"Withdraw Rupees{_ammount} .Remaining balance:rupees {_balance}";
        }

        public string Getbalance(string _enteredpin)
        {
            if (_enteredpin != _pin)
            {
                Console.WriteLine("Inalid Pin");
            }
            return $"Your Balance is Rupees {_balance}";
        }

        public static void Run()
        {
            Atm atm = new Atm();
            Console.WriteLine("Enter the pin ");
            string pin1 = Console.ReadLine();
            if (pin1 != atm._pin)
            {
                Console.WriteLine("Incorrect Pin! Exiting...");
                return; 
            }
            Console.WriteLine("Enter the amount to withdraw");
            double b = double.Parse(Console.ReadLine());
            string withdrawResult = atm.WithDraw(b, pin1);
            Console.WriteLine(withdrawResult);
            string balanceResult = atm.Getbalance(pin1);
            Console.WriteLine(balanceResult);



        }
    }
}
