using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SResMechanism
{
    public int CResMechanism { get; set; }

    public string NResMechanism { get; set; } = null!;

    public int? CUnit { get; set; }

    public string Code { get; set; } = null!;

    public double? CostBase { get; set; }

    public double? CostCalc { get; set; }

    public SUnit? CUnitNavigation { get; set; }

    public ICollection<SWorkResMechanism> SWorkResMechanisms { get; set; } = new List<SWorkResMechanism>();
}
