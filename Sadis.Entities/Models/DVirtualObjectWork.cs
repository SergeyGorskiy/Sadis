using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DVirtualObjectWork
{
    public int CVirtualObjectWork { get; set; }

    public int CWork { get; set; }

    public int CVirtualObject { get; set; }

    public DVirtualObject CVirtualObjectNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;

    public ICollection<DVirtualObjectMonth> DVirtualObjectMonths { get; set; } = new List<DVirtualObjectMonth>();

    public ICollection<DVirtualWorkCost> DVirtualWorkCosts { get; set; } = new List<DVirtualWorkCost>();
}
