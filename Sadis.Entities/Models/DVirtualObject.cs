using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DVirtualObject
{
    public int CVirtualObject { get; set; }

    public string NVirtualObject { get; set; } = null!;

    public string CodeVirtualObject { get; set; } = null!;

    public int CUnit { get; set; }

    public double CountValue { get; set; }

    public DateTime? DateLeadIn { get; set; }

    public DateTime? DateLeadOut { get; set; }

    public Guid? UniqueValue { get; set; }

    public int UsePlan { get; set; }

    public int UseFact { get; set; }

    public SUnit CUnitNavigation { get; set; } = null!;

    public ICollection<DVirtualObjectContract> DVirtualObjectContracts { get; set; } = new List<DVirtualObjectContract>();

    public ICollection<DVirtualObjectWork> DVirtualObjectWorks { get; set; } = new List<DVirtualObjectWork>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
