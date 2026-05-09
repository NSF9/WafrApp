namespace Wafr.DTOs.SavingGoals;

public class CreateSavingGoalRequestDTO
{
    public string Name { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    public decimal TargetAmount { get; set; }
}