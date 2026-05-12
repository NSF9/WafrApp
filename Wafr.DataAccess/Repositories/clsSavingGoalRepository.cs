using Wafr.Models.Entities;
using Wafr.Models.Enums;

namespace Wafr.DataAccess.Repositories
{
    public class clsSavingGoalRepository
    {
        public clsSavingGoal? GetByID(int savingGoalID)
        {
            throw new NotImplementedException();
        }

        public List<clsSavingGoal> GetByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public int Create(clsSavingGoal goal)
        {
            throw new NotImplementedException();
        }

        public bool Update(clsSavingGoal goal)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCurrentAmount(int savingGoalID, decimal newAmount)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStatus(int savingGoalID, enSavingGoalStatus status)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int savingGoalID)
        {
            throw new NotImplementedException();
        }
    }
}
