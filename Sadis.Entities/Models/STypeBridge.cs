using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class STypeBridge
{
    public int CTypeBridge { get; set; }

    public string NTypeBridge { get; set; } = null!;

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();
}
