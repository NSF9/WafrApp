using Wafr.DataAccess.Interfaces;
using Wafr.Models.Entities;

namespace Wafr.DataAccess.Repositories
{
    public class clsUserSettingsRepository : IUserSettingsRepository
    {
        public clsUserSettings? GetByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public int Create(clsUserSettings userSettings)
        {
            throw new NotImplementedException();
        }

        public bool Update(clsUserSettings userSettings)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWeeklyAmount(int userSettingID, decimal weeklyAmount)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSavingTarget(int userSettingID, decimal savingTarget)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWeekStartDay(int userSettingID, string weekStartDay)
        {
            throw new NotImplementedException();
        }
    }
}