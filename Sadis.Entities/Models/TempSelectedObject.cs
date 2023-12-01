using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TempSelectedObject
{
    public Guid CSelectedObjects { get; set; }

    public int CObject { get; set; }

    public int CTypeObject { get; set; }

    public int CRegion { get; set; }

    public int CExplCategory { get; set; }

    public int CClimatZone { get; set; }

    public int CContract { get; set; }

    public int CMonthBegin { get; set; }

    public int CMonthEnd { get; set; }

    public double? CoefObject { get; set; }

    public double? CoefSalary { get; set; }

    public double? CoefRegion { get; set; }

    public double? CoefArea { get; set; }

    public SClimatZone CClimatZoneNavigation { get; set; } = null!;

    public DContract CContractNavigation { get; set; } = null!;

    public SExplCategory CExplCategoryNavigation { get; set; } = null!;

    public DMonth CMonthBeginNavigation { get; set; } = null!;

    public DMonth CMonthEndNavigation { get; set; } = null!;

    public DObject CObjectNavigation { get; set; } = null!;

    public SRegion CRegionNavigation { get; set; } = null!;

    public STypeObject CTypeObjectNavigation { get; set; } = null!;
}
