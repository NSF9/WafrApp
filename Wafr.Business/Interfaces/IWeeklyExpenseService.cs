using Wafr.DTOs.WeeklyExpenses;

namespace Wafr.Business.Interfaces
{
    public interface IWeeklyExpenseService
    {
        public WeeklyExpenseResponseDTO AddWeeklyExpesneRequest(int UserID, AddWeeklyExpenseRequestDTO AddWeeklyExpesneRequest);

        public List<WeeklyExpenseResponseDTO> GetCurrentWeeklyExpenses(int UserID);

        public bool UpdateExpense(int ExpenseID, UpdateExpenseRequestDTO UpdateExpenseRequest);

        public bool DeleteExpense(int ExpenseID);
    }
}