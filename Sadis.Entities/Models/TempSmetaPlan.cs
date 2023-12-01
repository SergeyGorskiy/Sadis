using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TempSmetaPlan
{
    public Guid CSmeta { get; set; }

    public int? CContract { get; set; }

    public int? CObject { get; set; }

    public int? CVirtualObject { get; set; }

    public int? CElement { get; set; }

    public int? CRegion { get; set; }

    public int? CWorkGroup { get; set; }

    public int? KindWorkGroup { get; set; }

    public int? CWork { get; set; }

    public int? CObjectElement { get; set; }

    public double? CountValue { get; set; }

    public int? CExplCategory { get; set; }

    public int? CClimatZone { get; set; }

    public double? CoefValueWork { get; set; }

    public double? CoefContractor { get; set; }

    public double? CoefRegion { get; set; }

    public double? CoefObject { get; set; }

    public double? CoefSalary { get; set; }

    public double? Costonework { get; set; }

    public double? CostoneworkNow { get; set; }

    public double? FotValue { get; set; }

    public double? FotValueNow { get; set; }

    public int? CMonthBegin { get; set; }

    public int? CMonthEnd { get; set; }

    public int? CCiclic { get; set; }

    public int? CRoad { get; set; }

    public DateTime DateActual { get; set; }

    public int? CTypeObject { get; set; }

    public int? CKurator { get; set; }

    public string? KuratorName { get; set; }

    public SCiclic? CCiclicNavigation { get; set; }

    public SClimatZone? CClimatZoneNavigation { get; set; }

    public DContract? CContractNavigation { get; set; }

    public SElement? CElementNavigation { get; set; }

    public SExplCategory? CExplCategoryNavigation { get; set; }

    public DMonth? CMonthBeginNavigation { get; set; }

    public DMonth? CMonthEndNavigation { get; set; }

    public DObject? CObjectNavigation { get; set; }

    public DRoad? CRoadNavigation { get; set; }

    public STypeObject? CTypeObjectNavigation { get; set; }

    public DVirtualObject? CVirtualObjectNavigation { get; set; }

    public SWorkGroup? CWorkGroupNavigation { get; set; }

    public SWork? CWorkNavigation { get; set; }
}
