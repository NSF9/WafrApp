using Wafr.DTOs.Transfers;
namespace Wafr.Business.Interfaces
{
    public interface ITransferService
    {
        bool DistributeRemainingBalance(int WeekID);
    }
}
