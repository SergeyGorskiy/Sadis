using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesReport
{
    public int CReport { get; set; }

    public string NReport { get; set; } = null!;

    public DateTime? DateBeg { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? IsFormed { get; set; }

    public string? UserName { get; set; }

    public string? ReportLink { get; set; }
}
