using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DContractor
{
    public int CContractor { get; set; }

    public string NContractor { get; set; } = null!;

    public double? Coef { get; set; }

    public double? Nds { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Phone { get; set; }

    public string? Department { get; set; }

    public string? Post { get; set; }

    public int? AicContractor { get; set; }

    public int GeneratedUserId { get; set; }

    public byte EnabledDocExcel { get; set; }

    public bool? ReportExcel { get; set; }

    public ICollection<DApiToken> DApiTokens { get; set; } = new List<DApiToken>();

    public ICollection<DContractorDetail> DContractorDetails { get; set; } = new List<DContractorDetail>();

    public ICollection<DContractorRegion> DContractorRegions { get; set; } = new List<DContractorRegion>();

    public ICollection<DContract> DContracts { get; set; } = new List<DContract>();

    public ICollection<DGeneralContractor> DGeneralContractors { get; set; } = new List<DGeneralContractor>();

    public ICollection<DMaker> DMakers { get; set; } = new List<DMaker>();

    public ICollection<DSubcontractorWork> DSubcontractorWorks { get; set; } = new List<DSubcontractorWork>();

    public ICollection<TablesUser> TablesUsers { get; set; } = new List<TablesUser>();
}
