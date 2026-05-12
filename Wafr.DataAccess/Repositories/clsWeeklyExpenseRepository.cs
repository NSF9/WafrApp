using Wafr.DataAccess.Interfaces;
using Wafr.Models.Entities;

namespace Wafr.DataAccess.Repositories
{
    public class clsWeeklyExpenseRepository : IWeeklyExpenseRepository
    {
        public clsWeeklyExpense? GetByID(int weeklyExpenseID)
        {
            throw new NotImplementedException();
        }

        public List<clsWeeklyExpense> GetByWeekID(int weekID)
        {
            throw new NotImplementedException();
        }

        public int Create(clsWeeklyExpense weeklyExpense)
        {
            throw new NotImplementedException();
        }

        public bool Update(clsWeeklyExpense weeklyExpense)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int weeklyExpenseID)
        {
            throw new NotImplementedException();
        }
    }
}