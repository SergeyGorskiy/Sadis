using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DContractorRegion
{
    public int CContractorRegion { get; set; }

    public int CContractor { get; set; }

    public Guid UniqueValue { get; set; }

    public int CRegion { get; set; }

    public DContractor CContractorNavigation { get; set; } = null!;

    public SRegion CRegionNavigation { get; set; } = null!;
}
