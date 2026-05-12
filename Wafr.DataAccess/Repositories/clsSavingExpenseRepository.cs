using Wafr.DataAccess.Interfaces;
using Wafr.Models.Entities;

namespace Wafr.DataAccess.Repositories
{
    public class clsSavingExpenseRepository : ISavingExpenseRepository
    {
        public bool Create(clsSavingExpense savingExpense)
        {
            throw new NotImplementedException();
        }

        public List<clsSavingExpense> GetSavingExpensesByGoalID(int savingGoalID)
        {
            throw new NotSupportedException();
        }


        public clsSavingExpense? GetByID(int savingExpenseID)
        {
            throw new NotSupportedException();
        }

    }
}