using System;
using System.Collections.Generic;

namespace EFDay1.Models;

public partial class TransferHistory
{
    public long? TransferId { get; set; }

    public long? PlayerId { get; set; }

    public long? ToTeamId { get; set; }

    public long? FromTeamId { get; set; }

    public string? TransferDate { get; set; }

    public long? TransferFee { get; set; }

    public long? ContractDuration { get; set; }
}
