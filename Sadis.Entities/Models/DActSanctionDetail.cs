using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DActSanctionDetail
{
    public int CDetail { get; set; }

    public int CActSanction { get; set; }

    public int CObject { get; set; }

    public int CSanction { get; set; }

    public double SanctionValue { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? CObjectElement { get; set; }

    public string? SanctionComments { get; set; }

    public Guid? CDefect { get; set; }

    public int? AisSanctionId { get; set; }

    public double AisAmount { get; set; }

    public int? CKurator { get; set; }

    public string? KuratorName { get; set; }

    public string? NomerPred { get; set; }

    public DDefect? CDefectNavigation { get; set; }

    public DObjectElement? CObjectElementNavigation { get; set; }

    public DObject CObjectNavigation { get; set; } = null!;

    public SSanction CSanctionNavigation { get; set; } = null!;
}
