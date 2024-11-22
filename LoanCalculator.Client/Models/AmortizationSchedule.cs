namespace LoanCalculator.Models
{
    public class AmortizationSchedule
    {
        public static DateTime DateObj { get; set; } = DateTime.Today;
        public double MonthlyInterest { get; set; }
        public double PrincipalPaid { get; set; }
        public int Year { get; set; }
        public double RemainingBalance { get; set; }
        public int Month { get; set; } = DateObj.Month;
        public string MonthName { get; set; } = "";

        public string[] monthNames = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
        public double emi { get; set; }
        public double TotalInterest { get; set; }
        public double TotalAmount { get; set; }
        public double TotalPrincipal { get; set; }
        public double BeginBalance { get; set; }
        public DateTime YearN { get; set; }
        public double Principal { get; set; } = Calculation.PrincipalAmount;

        public static List<AmortizationSchedule> GridData = new List<AmortizationSchedule>();

        public static List<AmortizationSchedule> YearWiseData = new List<AmortizationSchedule>();
        public static double EMI { get; set; }
        public static double MonthlyPayment { get; set; }
        public static double InterestValue { get; set; }
        public int tent { get; set; }
        public static double InterestRate { get; set; }
        public string CheckedValue { get; set; } = "Year";   
    }
}
