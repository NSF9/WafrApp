namespace Wafr.DTOs.UserSettings;

public class UpdateUserSettingsRequestDTO
{
    public decimal WeeklyAmount { get; set; }

    public decimal WeeklySavingTarget { get; set; }

    public string WeeklyStartDay { get; set; } = string.Empty;

    public string Currency { get; set; } = "SAR";
}