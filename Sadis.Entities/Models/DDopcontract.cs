using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DDopcontract
{
    public int CDopcontract { get; set; }

    public string NDopcontract { get; set; } = null!;

    public string Number { get; set; } = null!;

    public DateTime DateBegin { get; set; }

    public DateTime DateEnd { get; set; }

    public DateTime DateCreate { get; set; }

    public bool? IsActive { get; set; }

    public int? CContract { get; set; }

    public int? CContractDel { get; set; }

    public int? CContractOld { get; set; }

    public int? CDopcontractOld { get; set; }

    public ICollection<DObjectContract> DObjectContracts { get; set; } = new List<DObjectContract>();
}
