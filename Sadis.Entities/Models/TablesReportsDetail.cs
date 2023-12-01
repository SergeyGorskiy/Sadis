using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesReportsDetail
{
    public int CReportDetail { get; set; }

    public int CReport { get; set; }

    public DateTime? DateReport { get; set; }

    public int CApplication { get; set; }

    public int CUser { get; set; }

    public string? ReportLink { get; set; }

    public string? ParamsReport { get; set; }
}
