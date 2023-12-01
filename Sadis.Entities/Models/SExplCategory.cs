using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SExplCategory
{
    public int CExplCategory { get; set; }

    public string NExplCategory { get; set; } = null!;

    public string NameExplCategory { get; set; } = null!;

    public string? Code { get; set; }

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();

    public ICollection<SCiclic> SCiclics { get; set; } = new List<SCiclic>();

    public ICollection<TempSelectedObject> TempSelectedObjects { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
