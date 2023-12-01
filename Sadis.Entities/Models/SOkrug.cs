using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SOkrug
{
    public int COkrug { get; set; }

    public string NOkrug { get; set; } = null!;

    public ICollection<SRegion> SRegions { get; set; } = new List<SRegion>();
}
