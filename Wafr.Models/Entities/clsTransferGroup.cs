namespace Wafr.Models.Entities;

public class clsTransferGroup
{
    public int TransferGroupID { get; set; }

    public int WeekID { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; }
}