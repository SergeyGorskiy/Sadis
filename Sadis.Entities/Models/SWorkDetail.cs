using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWorkDetail
{
    public int CWorkDetail { get; set; }

    public int CWork { get; set; }

    public int CWorkGroup { get; set; }

    public SWorkGroup CWorkGroupNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
