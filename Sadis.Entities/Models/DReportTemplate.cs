using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DReportTemplate
{
    public int CTemplate { get; set; }

    public int CReport { get; set; }

    public string NTemplate { get; set; } = null!;

    public byte[]? Settings { get; set; }
}
