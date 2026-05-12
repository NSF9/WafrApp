using Wafr.DTOs.Weeks;
using Wafr.DTOs.WeeklyExpenses;

namespace Wafr.Business.Interfaces
{
    public interface IWeekService
    {
        WeekResponseDTO? GetCurrentWeek(int userID);

        bool IsCurrentWeekExists(int userID);

        WeeklyExpenseResponseDTO AddWeeklyExpense(
            int userID,
            AddWeeklyExpenseRequestDTO request);

        CloseWeekResponseDTO CloseCurrentWeek(int userID);
    }
}