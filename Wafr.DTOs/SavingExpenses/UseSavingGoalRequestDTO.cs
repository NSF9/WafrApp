namespace Wafr.DTOs.SavingExpenses;

public class UseSavingGoalRequestDTO
{
    public decimal Amount { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public string? Note { get; set; }
}