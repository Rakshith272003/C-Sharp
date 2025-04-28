using System;
using System.Collections.Generic;
using TripExpenseSplitter.Business;
using TripExpenseSplitter.Utilities;

namespace TripExpenseSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Trip Expense Splitter ===\n");

            int numParticipants = InputHelper.ReadInt("Enter number of participants: ");
            List<Person> participants = new List<Person>();

            for (int i = 0; i < numParticipants; i++)
            {
                string name = InputHelper.ReadString($"\nEnter name of person {i + 1}: ");
                Person person = new Person { Name = name };

                int numExpenses = InputHelper.ReadInt($"How many expenses for {name}? ");
                for (int j = 0; j < numExpenses; j++)
                {
                    double expense = InputHelper.ReadDouble($"Enter amount of expense {j + 1} for {name}: ");
                    person.Expenses.Add(expense);
                }

                participants.Add(person);
            }

            string paidEntry = InputHelper.ReadString("\nDo you want to enter who paid? (y/n): ");
            if (paidEntry.ToLower() == "y")
            {
                foreach (var person in participants)
                {
                    person.AmountPaid = InputHelper.ReadDouble($"How much did {person.Name} pay? ");
                }
            }

            double totalPaid = 0;
            double totalSpent = 0;
            foreach (var person in participants)
            {
                totalPaid += person.AmountPaid;
                totalSpent += person.GetTotalSpent();
            }

            if (Math.Abs(totalPaid - totalSpent) > 0.01)
            {
                Console.WriteLine("\nError: Total paid does not match total spent. Cannot proceed with calculation.");
            }
            else
            {
                ExpenseManager manager = new ExpenseManager(participants);
                manager.PrintSummary();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
