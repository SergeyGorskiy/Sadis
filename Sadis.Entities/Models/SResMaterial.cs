using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SResMaterial
{
    public int CResMaterial { get; set; }

    public string NResMaterial { get; set; } = null!;

    public int? CUnit { get; set; }

    public string Code { get; set; } = null!;

    public double? CostBase { get; set; }

    public double? CostCalc { get; set; }

    public SUnit? CUnitNavigation { get; set; }

    public ICollection<SWorkResMaterial> SWorkResMaterials { get; set; } = new List<SWorkResMaterial>();
}
