using System;
using System.Collections.Generic;

namespace EFDay1.Models;

public partial class Player
{
    public long? PlayerId { get; set; }

    public long? TeamId { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Nationality { get; set; }

    public string? ContractUntil { get; set; }

    public long? MarketValue { get; set; }
}
