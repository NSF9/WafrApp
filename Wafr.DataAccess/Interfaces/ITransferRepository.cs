using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface ITransferGroupRepository
    {
        public clsTransferGroup? GetByWeekID(int weekID);

        public int Create(clsTransferGroup transferGroup);
    }
    public interface ITransferItemRepository
    {
        public bool Create(clsTransferItem transferItem);

        public bool CreateMany(List<clsTransferItem> transferItems);

        public List<clsTransferItem> GetByTransferGroupID(int transferGroupID);

        public List<clsTransferItem> GetBySavingGoalID(int savingGoalID);
    }

    public interface ITransferRepository : ITransferGroupRepository, ITransferItemRepository
    {

    }

}