using ProductionEfficiencyTracker.Models;
using ProductionEfficiencyTracker.Services;
using System;
using System.Collections.Generic;

namespace ProductionEfficiencyTracker.UI
{
    public static class ConsoleUI
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("\n📊 PRODUCTION EFFICIENCY TRACKER");
            Console.WriteLine("1. Add New Record");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Exit");
        }

        public static ProductionData GetProductionInput()
        {
            var data = new ProductionData();

            Console.Write("Enter Machine Name: ");
            data._MachineName = Console.ReadLine();

            Console.Write("Enter Total Units: ");
            data._TotalUnits = int.Parse(Console.ReadLine());

            Console.Write("Enter Defective Units: ");
            data._DefectiveUnits = int.Parse(Console.ReadLine());

            Console.Write("Enter Time Taken (in hours): ");
            data._TimeTaken = double.Parse(Console.ReadLine());

            return data;
        }

        public static void DisplayMetrics(ProductionData data)
        {
            Console.WriteLine($"\n🔧 Machine: {data._MachineName}");
            Console.WriteLine($"✅ Good Units: {MetricsCalculator.GetGoodUnits(data)}");
            Console.WriteLine($"📉 Defect Rate: {MetricsCalculator.GetDefectRate(data)}%");
            Console.WriteLine($"⚙️ Efficiency: {MetricsCalculator.GetEfficiency(data)}%");
            Console.WriteLine($"🚀 Units per Hour: {MetricsCalculator.GetProductionRate(data)}");

            string status = MetricsCalculator.GetEfficiency(data) < 85
                ? "⚠️ Status: Low Efficiency! Improve the process."
                : "✅ Status: Acceptable Efficiency.";

            Console.WriteLine(status);
        }

        public static void DisplayAllRecords(List<ProductionData> records)
        {
            Console.WriteLine("\n📋 Summary of All Records:");
            foreach (var item in records)
            {
                DisplayMetrics(item);
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
