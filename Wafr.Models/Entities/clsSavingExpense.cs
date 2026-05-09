namespace Wafr.Models.Entities;

public class clsSavingExpense
{
    public int SavingExpenseID { get; set; }

    public int SavingGoalID { get; set; }

    public decimal Amount { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; }
}