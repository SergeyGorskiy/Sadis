using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DVirtualObjectMonth
{
    public int CVirtualObjectMonth { get; set; }

    public int CMonth { get; set; }

    public int CVirtualObjectWork { get; set; }

    public double VirtualCost { get; set; }

    public DMonth CMonthNavigation { get; set; } = null!;

    public DVirtualObjectWork CVirtualObjectWorkNavigation { get; set; } = null!;
}
