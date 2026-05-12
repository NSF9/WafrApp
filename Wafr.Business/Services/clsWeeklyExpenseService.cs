using Wafr.DataAccess.Interfaces;

namespace Wafr.Business.Services
{
    public class clsWeeklyExpenseService
    {
        private readonly IWeeklyExpenseRepository _weeklyExpenseRepository;

        public clsWeeklyExpenseService(IWeeklyExpenseRepository weeklyExpenseRepository)
        {
            _weeklyExpenseRepository = weeklyExpenseRepository;
        }


    }
}