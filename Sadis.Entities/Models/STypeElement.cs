using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class STypeElement
{
    public int CTypeElement { get; set; }

    public string? NTypeElement { get; set; }

    public ICollection<SElement> SElements { get; set; } = new List<SElement>();
}
