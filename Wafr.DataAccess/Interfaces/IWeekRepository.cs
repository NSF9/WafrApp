using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface IWeekRepository
    {
        clsWeek? GetOpenWeekByUserID(int UserID);

        bool Create(clsWeek week);

        bool UpdateCurrentBalance(int WeekID, decimal newBalamce);

        bool CloseWeek(int WeekID);

        clsWeek? GetByID(int WeekID);
    }
}