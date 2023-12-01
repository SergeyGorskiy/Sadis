using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DMaker
{
    public int CMaker { get; set; }

    public int CContractor { get; set; }

    public string DisplayName { get; set; } = null!;

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Phone { get; set; }

    public string? Department { get; set; }

    public string? Post { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public byte IsActive { get; set; }

    public int? CSubcontractor { get; set; }

    public DContractor CContractorNavigation { get; set; } = null!;

    public DSubcontractor? CSubcontractorNavigation { get; set; }

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();
}
