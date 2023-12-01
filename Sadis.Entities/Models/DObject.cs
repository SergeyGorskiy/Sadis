using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DObject
{
    public int CObject { get; set; }

    public int? CBridgeObject { get; set; }

    public int CTypeObject { get; set; }

    public int CRegion { get; set; }

    public int CRoad { get; set; }

    public int? CStatusObject { get; set; }

    public int CExplCategory { get; set; }

    public int? CTypeBridge { get; set; }

    public int? CBridgeMaterial { get; set; }

    public string NObject { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Barrier { get; set; }

    public string? Gabarit { get; set; }

    public DateTime? DateLeadIn { get; set; }

    public DateTime? DateLeadOut { get; set; }

    public double? Length { get; set; }

    public double? Mp { get; set; }

    public double? Coef { get; set; }

    public double? Begkm { get; set; }

    public double? Endkm { get; set; }

    public string? BegkmStolb { get; set; }

    public string? EndkmStolb { get; set; }

    public Guid? UniqueValue { get; set; }

    public string? NBridgeLet { get; set; }

    public byte EnabledForJornal { get; set; }

    public SBridgeMaterial? CBridgeMaterialNavigation { get; set; }

    public DObject? CBridgeObjectNavigation { get; set; }

    public SExplCategory CExplCategoryNavigation { get; set; } = null!;

    public SRegion CRegionNavigation { get; set; } = null!;

    public DRoad CRoadNavigation { get; set; } = null!;

    public SStatusObject? CStatusObjectNavigation { get; set; }

    public STypeBridge? CTypeBridgeNavigation { get; set; }

    public STypeObject CTypeObjectNavigation { get; set; } = null!;

    public ICollection<DActSanctionDetail> DActSanctionDetails { get; set; } = new List<DActSanctionDetail>();

    public ICollection<DObjectContract> DObjectContracts { get; set; } = new List<DObjectContract>();

    public ICollection<DObjectElement> DObjectElements { get; set; } = new List<DObjectElement>();

    public ICollection<DObjectHistory> DObjectHistories { get; set; } = new List<DObjectHistory>();

    public ICollection<DObjectKurator> DObjectKurators { get; set; } = new List<DObjectKurator>();

    public ICollection<DObjectTypePokr> DObjectTypePokrs { get; set; } = new List<DObjectTypePokr>();

    public ICollection<DWeather> DWeathers { get; set; } = new List<DWeather>();

    public ICollection<DObject> InverseCBridgeObjectNavigation { get; set; } = new List<DObject>();

    public ICollection<TempSelectedObject> TempSelectedObjects { get; set; } = new List<TempSelectedObject>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
