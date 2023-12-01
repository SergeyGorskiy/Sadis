using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesLog
{
    public int CLog { get; set; }

    public int CApplication { get; set; }

    public int? CUser { get; set; }

    public int CType { get; set; }

    public string? NMessage { get; set; }

    public string? NUrl { get; set; }

    public DateTime DateCreate { get; set; }

    public int? CTable { get; set; }

    public int? CObject { get; set; }
}
