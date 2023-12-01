using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class STypePokr
{
    public int CTypePokr { get; set; }

    public string NTypePokr { get; set; } = null!;

    public int TypeGroup { get; set; }

    public ICollection<DObjectTypePokr> DObjectTypePokrs { get; set; } = new List<DObjectTypePokr>();
}
