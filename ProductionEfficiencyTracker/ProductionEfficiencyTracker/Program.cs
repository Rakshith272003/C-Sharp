using ProductionEfficiencyTracker.Models;
using ProductionEfficiencyTracker.UI;
using System;
using System.Collections.Generic;

namespace ProductionEfficiencyTracker
{
    class Program
    {
        static List<ProductionData> records = new List<ProductionData>();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                ConsoleUI.DisplayMenu();
                Console.Write("Select an option (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var newRecord = ConsoleUI.GetProductionInput();
                        records.Add(newRecord);
                        ConsoleUI.DisplayMetrics(newRecord);
                        break;

                    case "2":
                        ConsoleUI.DisplayAllRecords(records);
                        break;

                    case "3":
                        Console.WriteLine("👋 Exiting...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("❌ Invalid Option. Try Again.");
                        break;
                }
            }
        }
    }
}
