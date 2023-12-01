using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesFieldType
{
    public int CFieldType { get; set; }

    public string TName { get; set; } = null!;

    public ICollection<TablesType> TablesTypes { get; set; } = new List<TablesType>();
}
