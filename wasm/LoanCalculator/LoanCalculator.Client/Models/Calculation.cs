namespace LoanCalculator.Models
{
    public class Calculation
    {
        public static double PrincipalAmount { get; set; } = 300000;
        public static double Interest { get; set; } = 5.5;
        public static int LoanTermValue { get; set; } = 12;
        public DateTime DateValue { get; set; } = DateTime.Today;
    }
}
