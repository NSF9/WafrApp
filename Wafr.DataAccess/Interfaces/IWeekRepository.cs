using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface IWeekRepository
    {
        public clsWeek? GetOpenWeekByUserID(int UserID);

        public bool Create(clsWeek week);

        public bool UpdateCurrentBalance(int WeekID, decimal newBalamce);

        public bool CloseWeek(int WeekID);

        public clsWeek? GetByID(int WeekID);
    }
}