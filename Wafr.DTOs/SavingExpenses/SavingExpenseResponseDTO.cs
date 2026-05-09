namespace Wafr.DTOs.SavingExpenses;

public class SavingExpenseResponseDTO
{
    public int SavingExpenseID { get; set; }

    public decimal Amount { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; }
}