using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SSanctionGroup
{
    public int CSanctionGroup { get; set; }

    public int CSeason { get; set; }

    public string NSanctionGroup { get; set; } = null!;

    public string Claim { get; set; } = null!;

    public int? CTypeObject { get; set; }

    public SSeason CSeasonNavigation { get; set; } = null!;

    public STypeObject? CTypeObjectNavigation { get; set; }

    public ICollection<SSanction> SSanctions { get; set; } = new List<SSanction>();
}
