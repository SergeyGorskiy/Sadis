using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesUpdate
{
    public int CUpdate { get; set; }

    public int Code { get; set; }

    public string? Description { get; set; }

    public string DatePasp { get; set; } = null!;

    public int? Build { get; set; }
}
