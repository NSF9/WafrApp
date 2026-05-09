namespace Wafr.Models.Entities
{
    public class clsWeeklyExpense
    {
        public int WeeklyExpenseID { get; set; }
        public int WeekID { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Emoji { get; set; } = string.Empty;
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}