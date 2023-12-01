using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWorkResMachinist
{
    public int CWorkResMachinist { get; set; }

    public int CWork { get; set; }

    public int CResMachinist { get; set; }

    public double Value { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public SResMachinist CResMachinistNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
