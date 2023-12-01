using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWorkResMechanism
{
    public int CWorkResMechanism { get; set; }

    public int CWork { get; set; }

    public int CResMechanism { get; set; }

    public double Value { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public SResMechanism CResMechanismNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
