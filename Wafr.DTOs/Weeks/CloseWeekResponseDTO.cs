namespace Wafr.DTOs.Weeks;

public class CloseWeekResponseDTO
{
    public int WeekID { get; set; }

    public decimal WeeklyAmount { get; set; }

    public decimal TotalExpenses { get; set; }

    public decimal TransferredAmount { get; set; }

    public decimal SavingTarget { get; set; }

    public bool IsSavingTargetAchieved { get; set; }

    public DateTime ClosedAt { get; set; }
}