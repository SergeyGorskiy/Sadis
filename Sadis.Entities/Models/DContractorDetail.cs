using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DContractorDetail
{
    public int CContractorDetail { get; set; }

    public int CContractor { get; set; }

    public Guid UniqueValue { get; set; }

    public DContractor CContractorNavigation { get; set; } = null!;
}
