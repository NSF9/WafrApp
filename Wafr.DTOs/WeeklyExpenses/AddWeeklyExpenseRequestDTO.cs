namespace Wafr.DTOs.WeeklyExpenses;

public class AddWeeklyExpenseRequestDTO
{
    public decimal Amount { get; set; }

    public string Category { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public string? Note { get; set; }
}