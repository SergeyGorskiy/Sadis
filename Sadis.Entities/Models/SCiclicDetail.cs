using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SCiclicDetail
{
    public int CCiclicDetail { get; set; }

    public int CCiclic { get; set; }

    public int CMonth { get; set; }

    public double CiclicValue { get; set; }

    public SCiclic CCiclicNavigation { get; set; } = null!;

    public DMonth CMonthNavigation { get; set; } = null!;
}
