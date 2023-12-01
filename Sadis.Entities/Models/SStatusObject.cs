using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SStatusObject
{
    public int CStatusObject { get; set; }

    public string NStatusObject { get; set; } = null!;

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();
}
