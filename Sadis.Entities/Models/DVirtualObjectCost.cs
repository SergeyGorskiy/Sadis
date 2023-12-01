using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DVirtualObjectCost
{
    public int CVirtualObjectCost { get; set; }

    public int CVirtualObject { get; set; }

    public int CMonth { get; set; }

    public double VirtualCost { get; set; }

    public DMonth CMonthNavigation { get; set; } = null!;

    public DVirtualObject CVirtualObjectNavigation { get; set; } = null!;
}
