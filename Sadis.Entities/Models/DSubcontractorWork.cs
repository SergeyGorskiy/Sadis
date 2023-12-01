using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DSubcontractorWork
{
    public int CSubcontractorWork { get; set; }

    public int CSubcontractor { get; set; }

    public int CContractor { get; set; }

    public int CObjectContract { get; set; }

    public int CElement { get; set; }

    public int CWork { get; set; }

    public bool? IsActive { get; set; }

    public DContractor CContractorNavigation { get; set; } = null!;

    public SElement CElementNavigation { get; set; } = null!;

    public DObjectContract CObjectContractNavigation { get; set; } = null!;

    public DSubcontractor CSubcontractorNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
