using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SElement
{
    public int CElement { get; set; }

    public string NElement { get; set; } = null!;

    public int CTypeObject { get; set; }

    public int CUnit { get; set; }

    public int CTypeElement { get; set; }

    public bool UseInTranzit { get; set; }

    public STypeElement CTypeElementNavigation { get; set; } = null!;

    public STypeObject CTypeObjectNavigation { get; set; } = null!;

    public SUnit CUnitNavigation { get; set; } = null!;

    public ICollection<DObjectElement> DObjectElements { get; set; } = new List<DObjectElement>();

    public ICollection<DSubcontractorWork> DSubcontractorWorks { get; set; } = new List<DSubcontractorWork>();

    public ICollection<DWorkElement> DWorkElements { get; set; } = new List<DWorkElement>();

    public ICollection<SSanctionElement> SSanctionElements { get; set; } = new List<SSanctionElement>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
