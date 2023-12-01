using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DOverwork
{
    public int COverwork { get; set; }

    public int CWork { get; set; }

    public int CObjectElement { get; set; }

    public DObjectElement CObjectElementNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
