using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DObjectKurator
{
    public int CObjectKurator { get; set; }

    public int CObject { get; set; }

    public int? CUser { get; set; }

    public DateTime DateBeg { get; set; }

    public DateTime DateEnd { get; set; }

    public int? CMonthBegin { get; set; }

    public int? CMonthEnd { get; set; }

    public DObject CObjectNavigation { get; set; } = null!;
}
