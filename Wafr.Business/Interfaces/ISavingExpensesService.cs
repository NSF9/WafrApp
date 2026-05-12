using Wafr.DTOs.SavingExpenses;

namespace Wafr.Business.Interfaces
{
    public interface ISavingExpensesService
    {
        SavingExpenseResponseDTO UseSavingGoal(int SavingGoalID, UseSavingGoalRequestDTO UseSavingGoal);
    }
}
