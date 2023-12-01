using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesInfo
{
    public int CTablesInfo { get; set; }

    public Guid? UniqueValue { get; set; }

    public int Kind { get; set; }

    public string? Info { get; set; }

    public string? Notes { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }
}
