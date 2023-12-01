using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DOverworkDetail
{
    public int COverworkDetail { get; set; }

    public int COverwork { get; set; }

    public int CMonth { get; set; }

    public double? Costonework { get; set; }

    public double? CostoneworkNow { get; set; }

    public DMonth CMonthNavigation { get; set; } = null!;
}
