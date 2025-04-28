using ProductionEfficiencyTracker.Models;
using System;

namespace ProductionEfficiencyTracker.Services
{
    public static class MetricsCalculator
    {
        public static int GetGoodUnits(ProductionData data)
        {
            return Math.Max(data._TotalUnits - data._DefectiveUnits, 0);
        }

        public static double GetEfficiency(ProductionData data)
        {
            return Math.Round(((double)GetGoodUnits(data) / Math.Max(data._TotalUnits, 1)) * 100, 2);
        }

        public static double GetDefectRate(ProductionData data)
        {
            return Math.Round(((double)data._DefectiveUnits / Math.Max(data._TotalUnits, 1)) * 100, 2);
        }

        public static double GetProductionRate(ProductionData data)
        {
            return Math.Round(GetGoodUnits(data) / Math.Max(data._TimeTaken, 1), 2);
        }
    }
}
