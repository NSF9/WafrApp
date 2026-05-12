using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface ISavingExpenseRepository
    {
        public bool Create(clsSavingExpense savingExpense);

        public List<clsSavingExpense> GetSavingExpensesByGoalID(
            int savingGoalID);

        public clsSavingExpense? GetByID(
            int savingExpenseID);
    }
}
