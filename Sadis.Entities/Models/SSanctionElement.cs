using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SSanctionElement
{
    public int CSanctionElement { get; set; }

    public int CSanction { get; set; }

    public int CElement { get; set; }

    public SElement CElementNavigation { get; set; } = null!;

    public SSanction CSanctionNavigation { get; set; } = null!;
}
