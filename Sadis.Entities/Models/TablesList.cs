using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesList
{
    public int CTable { get; set; }

    public int? CParent { get; set; }

    public int? CGroup { get; set; }

    public string NTable { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte IsSprav { get; set; }

    public byte UseImages { get; set; }

    public byte UseScheme { get; set; }

    public string? Notes { get; set; }

    public byte? SpravType { get; set; }
}
