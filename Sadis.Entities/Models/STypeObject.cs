using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class STypeObject
{
    public int CTypeObject { get; set; }

    public string NTypeObject { get; set; } = null!;

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();

    public ICollection<SElement> SElements { get; set; } = new List<SElement>();

    public ICollection<SSanctionGroup> SSanctionGroups { get; set; } = new List<SSanctionGroup>();

    public ICollection<TempSelectedObject> TempSelectedObjects { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
