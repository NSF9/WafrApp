namespace Wafr.DTOs.SavingGoals;

public class SavingGoalResponseDTO
{
    public int SavingGoalID { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public decimal TargetAmount { get; set; }

    public decimal CurrentAmount { get; set; }

    public string Status { get; set; } = string.Empty;

    public decimal ProgressPercentage { get; set; }
}