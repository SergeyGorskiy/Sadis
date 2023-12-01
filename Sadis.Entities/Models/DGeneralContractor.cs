using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DGeneralContractor
{
    public int CGeneralContractor { get; set; }

    public string NGeneralContractor { get; set; } = null!;

    public double? Nds { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Phone { get; set; }

    public string? Department { get; set; }

    public string? Post { get; set; }

    public int? CContractor { get; set; }

    public DContractor? CContractorNavigation { get; set; }

    public ICollection<DGeneralContract> DGeneralContracts { get; set; } = new List<DGeneralContract>();

    public ICollection<TablesUser> TablesUsers { get; set; } = new List<TablesUser>();
}
