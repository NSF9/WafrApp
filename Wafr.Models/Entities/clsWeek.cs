namespace Wafr.Models.Entities
{
    public class clsWeek
    {
        public int WeekID { get; set; }
        public int UserID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal WeeklyAmount { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal SavingTarget { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? ClosedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}