using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DContract
{
    public int CContract { get; set; }

    public int CGeneralContract { get; set; }

    public int CContractor { get; set; }

    public int CTypeBlock { get; set; }

    public string? NContract { get; set; }

    public string? NBlock { get; set; }

    public double? Deflator { get; set; }

    public Guid UniqueValue { get; set; }

    public string? NContractUser { get; set; }

    public string? NBlockUser { get; set; }

    public int DayCanRedactJournal { get; set; }

    public DContractor CContractorNavigation { get; set; } = null!;

    public DGeneralContract CGeneralContractNavigation { get; set; } = null!;

    public ICollection<DAct> DActs { get; set; } = new List<DAct>();

    public ICollection<DDeflatorUser> DDeflatorUsers { get; set; } = new List<DDeflatorUser>();

    public ICollection<DObjectContract> DObjectContracts { get; set; } = new List<DObjectContract>();

    public ICollection<DVirtualObjectContract> DVirtualObjectContracts { get; set; } = new List<DVirtualObjectContract>();

    public ICollection<TempSelectedObject> TempSelectedObjects { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
