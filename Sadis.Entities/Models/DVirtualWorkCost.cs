using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DVirtualWorkCost
{
    public int CVirtualWorkCost { get; set; }

    public int CVirtualWork { get; set; }

    public int CMonth { get; set; }

    public double VirtualCost { get; set; }

    public DVirtualObjectWork CVirtualWorkNavigation { get; set; } = null!;
}
