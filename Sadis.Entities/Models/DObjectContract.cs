using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DObjectContract
{
    public int CObjectContract { get; set; }

    public int CContract { get; set; }

    public int CObject { get; set; }

    public int MonthBeg { get; set; }

    public int MonthEnd { get; set; }

    public int CContractor { get; set; }

    public int CGeneralContract { get; set; }

    public int CGeneralContractor { get; set; }

    public bool? IsActive { get; set; }

    public int? CDopcontract { get; set; }

    public int? LastCObjectContract { get; set; }

    public DContract CContractNavigation { get; set; } = null!;

    public DDopcontract? CDopcontractNavigation { get; set; }

    public DObject CObjectNavigation { get; set; } = null!;

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();

    public ICollection<DSubcontractorWork> DSubcontractorWorks { get; set; } = new List<DSubcontractorWork>();

    public DMonth MonthBegNavigation { get; set; } = null!;

    public DMonth MonthEndNavigation { get; set; } = null!;
}
