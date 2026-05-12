using Wafr.DTOs.Transfers;

namespace Wafr.DTOs.Weeks;

public class CloseWeekRequestDTO
{
    public List<TransferItemRequestDTO> TransferItems { get; set; } = [];
}