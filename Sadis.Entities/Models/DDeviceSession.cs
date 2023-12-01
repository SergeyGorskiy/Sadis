using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DDeviceSession
{
    public Guid CDeviceSession { get; set; }

    public string CDevice { get; set; } = null!;

    public int CRoad { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public string? Json { get; set; }

    public DDevice CDeviceNavigation { get; set; } = null!;

    public DRoad CRoadNavigation { get; set; } = null!;

    public ICollection<DDefect> DDefects { get; set; } = new List<DDefect>();
}
