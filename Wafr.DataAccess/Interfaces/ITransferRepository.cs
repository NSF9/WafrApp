using Wafr.Models.Entities;

namespace Wafr.DataAccess.Interfaces
{
    public interface ITransferGroupRepository
    {
        clsTransferGroup? GetByWeekID(int weekID);

        int Create(clsTransferGroup transferGroup);
    }
    public interface ITransferItemRepository
    {
        bool Create(clsTransferItem transferItem);

        bool CreateMany(List<clsTransferItem> transferItems);

        List<clsTransferItem> GetByTransferGroupID(int transferGroupID);

        List<clsTransferItem> GetBySavingGoalID(int savingGoalID);
    }

    public interface ITransferRepository : ITransferGroupRepository, ITransferItemRepository
    {
       
    }

}