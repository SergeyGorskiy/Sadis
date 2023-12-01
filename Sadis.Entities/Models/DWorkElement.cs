using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DWorkElement
{
    public int CElement { get; set; }

    public int CWorkGroup { get; set; }

    public int CWorkElement { get; set; }

    public SElement CElementNavigation { get; set; } = null!;

    public SWorkGroup CWorkGroupNavigation { get; set; } = null!;
}
