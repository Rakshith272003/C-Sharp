using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public class AtmMenu
    {
        public static void Show()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
