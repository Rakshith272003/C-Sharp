using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public class ATM
    {
        private double _balance;
        private string _pin;

        public ATM(string pin, double initialBalance)
        {
            _pin = pin;
            _balance = initialBalance;
        }
        public double Balance
        {
            get { return _balance; }
            private set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
            }

        }
        public string Pin
        {
            get { return _pin; }
            private set
            {
                _pin = value;
            }
        }

        public bool ValidatePin(string enteredPin)
        {
            return _pin == enteredPin;
        }

        public string Withdraw(double amount)
        {
            if (amount > _balance)
                return " Insufficient balance.";
            _balance -= amount;
            return $" Withdrawn ₹{amount}. Remaining: ₹{_balance}";
        }

        public string Deposit(double amount)
        {
            if (amount <= 0)
                return " Invalid deposit amount.";
            _balance += amount;
            return $" Deposited ₹{amount}. New Balance: ₹{_balance}";
        }

        public string CheckBalance()
        {
            return $" Your current balance is ₹{_balance}";
        }

        public string ChangePin(string oldPin, string newPin)
        {
            if (_pin != oldPin)
                return "Incorrect old PIN.";
            _pin = newPin;
            return "PIN changed successfully.";
        }

    }
}
