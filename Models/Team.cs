using System;
using System.Collections.Generic;

namespace EFDay1.Models;

public partial class Team
{
    public long? TeamId { get; set; }

    public string? TeamName { get; set; }

    public long? FoundedYear { get; set; }

    public string? HomeCity { get; set; }

    public string? ManagerName { get; set; }

    public string? StadiumName { get; set; }

    public long? StadiumCapacity { get; set; }

    public string? Country { get; set; }
}
