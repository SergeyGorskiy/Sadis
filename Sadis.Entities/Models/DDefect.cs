using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DDefect
{
    public Guid CDefect { get; set; }

    public DateTime Date { get; set; }

    public int Group { get; set; }

    public int Type { get; set; }

    public double Begkm { get; set; }

    public double? Endkm { get; set; }

    public DateTime DateCreate { get; set; }

    public Guid CDeviceSession { get; set; }

    public string? ErrorMessage { get; set; }

    public bool IsLinked { get; set; }

    public DDeviceSession CDeviceSessionNavigation { get; set; } = null!;

    public ICollection<DActSanctionDetail> DActSanctionDetails { get; set; } = new List<DActSanctionDetail>();
}
