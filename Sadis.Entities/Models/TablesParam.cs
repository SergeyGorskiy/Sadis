using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesParam
{
    public int CParam { get; set; }

    public string ParamName { get; set; } = null!;

    public double ParamValue { get; set; }

    public string? ParamValueStr { get; set; }
}
