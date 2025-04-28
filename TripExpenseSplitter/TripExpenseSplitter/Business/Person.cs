using System.Collections.Generic;

namespace TripExpenseSplitter.Business
{
    public class Person
    {
        public string Name { get; set; }
        public List<double> Expenses { get; set; }
        public double AmountPaid { get; set; }

        public Person()
        {
            Expenses = new List<double>();
        }

        public double GetTotalSpent()
        {
            double total = 0;
            for (int i = 0; i < Expenses.Count; i++)
            {
                total += Expenses[i];
            }
            return total;
        }
    }
}