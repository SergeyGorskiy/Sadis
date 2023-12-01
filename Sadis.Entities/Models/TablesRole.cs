using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesRole
{
    public int CRole { get; set; }

    public string NRole { get; set; } = null!;

    public byte? Block { get; set; }

    public ICollection<TablesUser> TablesUsers { get; set; } = new List<TablesUser>();
}
