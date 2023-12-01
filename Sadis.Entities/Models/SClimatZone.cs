using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SClimatZone
{
    public int CClimatZone { get; set; }

    public string NClimatZone { get; set; } = null!;

    public string NameClimatZone { get; set; } = null!;

    public ICollection<SCiclic> SCiclics { get; set; } = new List<SCiclic>();

    public ICollection<SRegion> SRegions { get; set; } = new List<SRegion>();

    public ICollection<TempSelectedObject> TempSelectedObjects { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
