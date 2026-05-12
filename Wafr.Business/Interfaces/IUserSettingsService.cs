using Wafr.DTOs.UserSettings;

namespace Wafr.Business.Interfaces
{
    public interface IUserSettingsService
    {
        UserSettingsResponseDTO UpdateUserSettings(int UserID, UpdateUserSettingsRequestDTO UpdateUserSettings);
    }
}