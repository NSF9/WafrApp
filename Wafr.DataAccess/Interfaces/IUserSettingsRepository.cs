using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface IUserSettingsRepository
    {
        clsUserSettings? GetByUserID(int userID);

        int Create(clsUserSettings userSettings);

        bool Update(clsUserSettings userSettings);

        bool UpdateWeeklyAmount(int userSettingID, decimal weeklyAmount);

        bool UpdateSavingTarget(int userSettingID, decimal savingTarget);

        bool UpdateWeekStartDay(int userSettingID, string weekStartDay);
    }
}