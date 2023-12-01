using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesSetting
{
    public int CSettings { get; set; }

    public string? PriceLevel { get; set; }

    public DateTime? ActualReport { get; set; }

    public string? ActualReportComment { get; set; }

    public string? SmetaName { get; set; }

    public DateTime? SmetaDateBegin { get; set; }

    public DateTime? SmetaDateEnd { get; set; }

    public int? ActualObject { get; set; }

    public int? ActualBridge { get; set; }

    public DateTime? ActualVirtualReport { get; set; }
}
