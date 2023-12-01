using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWorkResMaterial
{
    public int CWorkResMaterial { get; set; }

    public int CWork { get; set; }

    public int CResMaterial { get; set; }

    public double Value { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public SResMaterial CResMaterialNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
