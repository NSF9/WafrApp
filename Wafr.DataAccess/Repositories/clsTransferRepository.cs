using Wafr.DataAccess.Interfaces;
using Wafr.Models.Entities;

namespace Wafr.DataAccess.Repositories
{
    public class clsTransferRepository : ITransferRepository
    {
        public clsTransferGroup? GetByWeekID(int weekID)
        {
            throw new NotImplementedException();
        }

        public int Create(clsTransferGroup transferGroup)
        {
            throw new NotImplementedException();
        }

        public bool Create(clsTransferItem transferItem)
        {
            throw new NotImplementedException();
        }

        public bool CreateMany(List<clsTransferItem> transferItems)
        {
            throw new NotImplementedException();
        }

        public List<clsTransferItem> GetByTransferGroupID(int transferGroupID)
        {
            throw new NotImplementedException();
        }

        public List<clsTransferItem> GetBySavingGoalID(int savingGoalID)
        {
            throw new NotImplementedException();
        }
    }
}