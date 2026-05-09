using Wafr.DTOs.SavingGoals;
using Wafr.DTOs.WeeklyExpenses;

namespace Wafr.DTOs.Home;

public class HomeDashboardResponseDTO
{
    public decimal WeeklyAmount { get; set; }

    public decimal CurrentBalance { get; set; }

    public decimal SavingTarget { get; set; }

    public decimal SavedThisWeek { get; set; }

    public string WeekStatus { get; set; } = string.Empty;

    public List<SavingGoalResponseDTO> ActiveGoals { get; set; }
        = new List<SavingGoalResponseDTO>();

    public List<WeeklyExpenseResponseDTO> RecentExpenses { get; set; }
        = new List<WeeklyExpenseResponseDTO>();
}