using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SBridgeMaterial
{
    public int CBridgeMaterial { get; set; }

    public string NBridgeMaterial { get; set; } = null!;

    public string? ShortBridgeMaterial { get; set; }

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();
}
