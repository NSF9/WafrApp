using Wafr.DataAccess.Interfaces;
using Wafr.Models.Entities;

namespace Wafr.DataAccess.Repositories
{
    public class clsWeekRepository : IWeekRepository
    {
        public clsWeek? GetOpenWeekByUserID(int UserID)
        {
            throw new NotImplementedException();
        }

        public bool Create(clsWeek week)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCurrentBalance(int WeekID, decimal newBalamce)
        {
            throw new NotImplementedException();
        }

        public bool CloseWeek(int WeekID)
        {
            throw new NotImplementedException();
        }

        public clsWeek? GetByID(int WeekID)
        {
            throw new NotImplementedException();
        }

    }
}