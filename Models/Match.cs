using System;
using System.Collections.Generic;

namespace EFDay1.Models;

public partial class Match
{
    public long? MatchId { get; set; }

    public string? Date { get; set; }

    public long? HomeTeamId { get; set; }

    public long? AwayTeamId { get; set; }

    public long? HomeTeamScore { get; set; }

    public long? AwayTeamScore { get; set; }

    public string? Stadium { get; set; }

    public string? Referee { get; set; }
}
