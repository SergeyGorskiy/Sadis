using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SSanction
{
    public int CSanction { get; set; }

    public int CSanctionGroup { get; set; }

    public string Code { get; set; } = null!;

    public string NSanction { get; set; } = null!;

    public double Penalty { get; set; }

    public int TypeDefect { get; set; }

    public int Multiplicator { get; set; }

    public SSanctionGroup CSanctionGroupNavigation { get; set; } = null!;

    public ICollection<DActSanctionDetail> DActSanctionDetails { get; set; } = new List<DActSanctionDetail>();

    public ICollection<SSanctionElement> SSanctionElements { get; set; } = new List<SSanctionElement>();
}
