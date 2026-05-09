namespace Wafr.DTOs.WeeklyExpenses;

public class WeeklyExpenseResponseDTO
{
    public int WeeklyExpenseID { get; set; }

    public decimal Amount { get; set; }

    public string Category { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; }
}