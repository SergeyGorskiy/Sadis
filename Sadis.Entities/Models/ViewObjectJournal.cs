using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class ViewObjectJournal
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
}
