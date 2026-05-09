namespace Wafr.Models.Entities
{
    public class clsUserSettings
    {
        public int UserSettingID {  get; set; }
        public int UserID { get; set; }
        public decimal WeeklyAmount { get; set; }
        public decimal WeeklySavingTarget {  get; set; }
        public string WeeklyStartDay { get; set; } = string.Empty;
        public string Currency { get; set; } = "SAR";
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}