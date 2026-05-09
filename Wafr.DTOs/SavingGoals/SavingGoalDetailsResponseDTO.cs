using Wafr.DTOs.SavingExpenses;

namespace Wafr.DTOs.SavingGoals;

public class SavingGoalDetailsResponseDTO
{
    public int SavingGoalID { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public decimal TargetAmount { get; set; }

    public decimal CurrentAmount { get; set; }

    public decimal RemainingAmount { get; set; }

    public decimal ProgressPercentage { get; set; }

    public string Status { get; set; } = string.Empty;

    public List<SavingExpenseResponseDTO> Expenses { get; set; }
        = new List<SavingExpenseResponseDTO>();
}