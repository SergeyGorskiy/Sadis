using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DVirtualObjectContract
{
    public int CVirtualObjectContract { get; set; }

    public int CContract { get; set; }

    public int CVirtualObject { get; set; }

    public int MonthBeg { get; set; }

    public int MonthEnd { get; set; }

    public DContract CContractNavigation { get; set; } = null!;

    public DVirtualObject CVirtualObjectNavigation { get; set; } = null!;
}
