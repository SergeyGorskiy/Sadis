using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SSeason
{
    public int CSeason { get; set; }

    public string NSeason { get; set; } = null!;

    public ICollection<SSanctionGroup> SSanctionGroups { get; set; } = new List<SSanctionGroup>();
}
