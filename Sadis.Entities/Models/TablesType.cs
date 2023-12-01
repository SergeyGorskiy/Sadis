using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesType
{
    public int CType { get; set; }

    public int CFieldType { get; set; }

    public int TValue { get; set; }

    public string TName { get; set; } = null!;

    public string? NShort { get; set; }

    public int? Color { get; set; }

    public int Enabled { get; set; }

    public TablesFieldType CFieldTypeNavigation { get; set; } = null!;
}
