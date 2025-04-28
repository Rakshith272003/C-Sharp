// ExpenseManager.cs
using System;
using System.Collections.Generic;
using TripExpenseSplitter.Repository;

namespace TripExpenseSplitter.Business
{
    public class ExpenseManager
    {
        private List<Person> people;

        public ExpenseManager(List<Person> people)
        {
            this.people = people;
        }

        public double CalculateTotalTripCost()
        {
            double total = 0;
            foreach (var person in people)
            {
                total += person.GetTotalSpent();
            }
            return total;
        }

        public bool ValidateTotalPaidEqualsTotalSpent()
        {
            double totalSpent = 0;
            double totalPaid = 0;
            foreach (var person in people)
            {
                totalSpent += person.GetTotalSpent();
                totalPaid += person.AmountPaid;
            }
            return Math.Abs(totalSpent - totalPaid) < 0.01; // allow tiny floating point error
        }

        public void PrintSummary()
        {
            Console.WriteLine("\n--- Trip Expense Summary ---");
            double totalTripCost = CalculateTotalTripCost();
            Console.WriteLine($"Total Trip Cost: ₹{totalTripCost}");

            Console.WriteLine("\n--- Individual Spent ---");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} spent: ₹{person.GetTotalSpent()}");
            }

            Console.WriteLine("\n--- Payments Made ---");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} paid: ₹{person.AmountPaid}");
            }

            Console.WriteLine("\n--- Balance Sheet ---");
            foreach (var creditor in people)
            {
                double balance = creditor.AmountPaid - creditor.GetTotalSpent();
                if (balance > 0)
                {
                    foreach (var debtor in people)
                    {
                        double debtorBalance = debtor.AmountPaid - debtor.GetTotalSpent();
                        if (debtorBalance < 0)
                        {
                            double amountOwed = Math.Min(balance, -debtorBalance);
                            Console.WriteLine($"{debtor.Name} owes ₹{amountOwed} to {creditor.Name}");
                            balance -= amountOwed;
                            debtor.AmountPaid += amountOwed;
                            creditor.AmountPaid -= amountOwed;
                            if (balance <= 0)
                                break;
                        }
                    }
                }
            }
        }
    }
}
