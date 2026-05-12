using Wafr.Models.Entities;
using Wafr.Models.Enums;

namespace Wafr.DataAccess.Interfaces
{
    public interface ISavingGoalRepository
    {
        public clsSavingGoal? GetByID(int savingGoalID);

        public List<clsSavingGoal> GetByUserID(int userID);

        public int Create(clsSavingGoal goal);

        public bool Update(clsSavingGoal goal);

        public bool UpdateCurrentAmount(int savingGoalID, decimal newAmount);

        public bool UpdateStatus(int savingGoalID, enSavingGoalStatus status);

        public bool Delete(int savingGoalID);
    }
}