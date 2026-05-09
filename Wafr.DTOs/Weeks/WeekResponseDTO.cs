namespace Wafr.DTOs.Weeks;

public class WeekResponseDTO
{
    public int WeekID { get; set; }
    public decimal WeeklyAmount { get; set; }
    public decimal CurrentBalance { get; set; }
    public decimal SavingTarget { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}