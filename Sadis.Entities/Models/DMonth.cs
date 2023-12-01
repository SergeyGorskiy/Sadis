using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DMonth
{
    public int CMonth { get; set; }

    public string NMonth { get; set; } = null!;

    public int Year { get; set; }

    public int MonthNum { get; set; }

    public int Number { get; set; }

    public ICollection<DAct> DActs { get; set; } = new List<DAct>();

    public ICollection<DGeneralContract> DGeneralContractCMonthBeginNavigations { get; set; } = new List<DGeneralContract>();

    public ICollection<DGeneralContract> DGeneralContractCMonthEndNavigations { get; set; } = new List<DGeneralContract>();

    public ICollection<DObjectContract> DObjectContractMonthBegNavigations { get; set; } = new List<DObjectContract>();

    public ICollection<DObjectContract> DObjectContractMonthEndNavigations { get; set; } = new List<DObjectContract>();

    public ICollection<DOverworkDetail> DOverworkDetails { get; set; } = new List<DOverworkDetail>();

    public ICollection<DVirtualObjectMonth> DVirtualObjectMonths { get; set; } = new List<DVirtualObjectMonth>();

    public ICollection<SCiclicDetail> SCiclicDetails { get; set; } = new List<SCiclicDetail>();

    public ICollection<TempSelectedObject> TempSelectedObjectCMonthBeginNavigations { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSelectedObject> TempSelectedObjectCMonthEndNavigations { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSmetaPlan> TempSmetaPlanCMonthBeginNavigations { get; set; } = new List<TempSmetaPlan>();

    public ICollection<TempSmetaPlan> TempSmetaPlanCMonthEndNavigations { get; set; } = new List<TempSmetaPlan>();

    public ICollection<TempSmetum> TempSmetumCMonthBeginNavigations { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetum> TempSmetumCMonthEndNavigations { get; set; } = new List<TempSmetum>();
}
