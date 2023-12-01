using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DActPlan
{
    public int CActPlan { get; set; }

    public int CAct { get; set; }

    public double Cost { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public DAct CActNavigation { get; set; } = null!;
}
