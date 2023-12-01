using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SResMachinist
{
    public int CResMachinist { get; set; }

    public string NResMachinist { get; set; } = null!;

    public int? CUnit { get; set; }

    public string Code { get; set; } = null!;

    public double? CostBase { get; set; }

    public double? CostCalc { get; set; }

    public SUnit? CUnitNavigation { get; set; }

    public ICollection<SWorkResMachinist> SWorkResMachinists { get; set; } = new List<SWorkResMachinist>();
}
