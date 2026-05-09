using Wafr.Models.Entities;
using Wafr.Models.Enums;

namespace Wafr.DataAccess.Interfaces
{
    public interface ISavingGoalRepository
    {
        clsSavingGoal? GetByID(int savingGoalID);

        List<clsSavingGoal> GetByUserID(int userID);

        int Create(clsSavingGoal goal);

        bool Update(clsSavingGoal goal);

        bool UpdateCurrentAmount(int savingGoalID, decimal newAmount);

        bool UpdateStatus(int savingGoalID, enSavingGoalStatus status);

        bool Delete(int savingGoalID);
    }
}