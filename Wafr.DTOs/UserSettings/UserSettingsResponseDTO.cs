namespace Wafr.DTOs.UserSettings;

public class UserSettingsResponseDTO
{
    public decimal WeeklyAmount { get; set; }

    public decimal WeeklySavingTarget { get; set; }

    public string WeeklyStartDay { get; set; } = string.Empty;

    public string Currency { get; set; } = string.Empty;
}