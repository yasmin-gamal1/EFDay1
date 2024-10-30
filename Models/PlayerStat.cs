using System;
using System.Collections.Generic;

namespace EFDay1.Models;

public partial class PlayerStat
{
    public long? StatId { get; set; }

    public long? PlayerId { get; set; }

    public long? MatchId { get; set; }

    public long? Goals { get; set; }

    public double? Assists { get; set; }

    public long? YellowCards { get; set; }

    public long? RedCards { get; set; }

    public long? MinutesPlayed { get; set; }
}
