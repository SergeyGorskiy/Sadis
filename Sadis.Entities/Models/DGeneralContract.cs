using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DGeneralContract
{
    public int CGeneralContract { get; set; }

    public string? NGeneralContract { get; set; }

    public int? CGeneralContractor { get; set; }

    public string Number { get; set; } = null!;

    public DateTime? DateBegin { get; set; }

    public int CMonthBegin { get; set; }

    public int CMonthEnd { get; set; }

    public int DeflatorMode { get; set; }

    public DGeneralContractor? CGeneralContractorNavigation { get; set; }

    public DMonth CMonthBeginNavigation { get; set; } = null!;

    public DMonth CMonthEndNavigation { get; set; } = null!;

    public ICollection<DContract> DContracts { get; set; } = new List<DContract>();

    public ICollection<DDeflator> DDeflators { get; set; } = new List<DDeflator>();
}
