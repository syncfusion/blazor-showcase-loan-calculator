namespace LoanCalculator.Models
{
    public class AmortizationChart
    {
        public double XValue { get; set; }
        public double YValue { get; set; }

        public static List<AmortizationChart> ChartData = new List<AmortizationChart>();
    }
}
