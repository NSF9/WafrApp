using Wafr.DTOs.WeeklyExpenses;

namespace Wafr.Business.Interfaces
{
    public interface IWeeklyExpenseService
    {
        WeeklyExpenseResponseDTO AddWeeklyExpesneRequest(int UserID, AddWeeklyExpenseRequestDTO AddWeeklyExpesneRequest);

        List<WeeklyExpenseResponseDTO> GetCurrentWeeklyExpenses(int UserID);

        bool UpdateExpense(int ExpenseID, UpdateExpenseRequestDTO UpdateExpenseRequest);

        bool DeleteExpense(int ExpenseID);
    }
}