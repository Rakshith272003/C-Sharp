namespace ProductionEfficiencyTracker.Models
{
    public class ProductionData
    {
        public string _MachineName { get; set; }
        public int _TotalUnits { get; set; }
        public int _DefectiveUnits { get; set; }
        public double _TimeTaken { get; set; }
    }
}
