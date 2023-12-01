using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWorkGroup
{
    public int CWorkGroup { get; set; }

    public string NWorkGroup { get; set; } = null!;

    public int? Kind { get; set; }

    public ICollection<DWorkElement> DWorkElements { get; set; } = new List<DWorkElement>();

    public ICollection<SCiclic> SCiclics { get; set; } = new List<SCiclic>();

    public ICollection<SWorkDetail> SWorkDetails { get; set; } = new List<SWorkDetail>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
