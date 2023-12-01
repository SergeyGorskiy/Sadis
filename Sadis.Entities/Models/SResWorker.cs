using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SResWorker
{
    public int CResWorker { get; set; }

    public string NResWorker { get; set; } = null!;

    public int? CUnit { get; set; }

    public string Code { get; set; } = null!;

    public double? CostBase { get; set; }

    public double? CostCalc { get; set; }

    public SUnit? CUnitNavigation { get; set; }

    public ICollection<SWorkResWorker> SWorkResWorkers { get; set; } = new List<SWorkResWorker>();
}
