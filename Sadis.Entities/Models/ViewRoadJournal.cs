using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class ViewRoadJournal
{
    public int CRoad { get; set; }

    public string NRoad { get; set; } = null!;

    public string? Code { get; set; }

    public double? Begkm { get; set; }

    public double? Endkm { get; set; }

    public DateTime? DateActualization { get; set; }

    public Guid UniqueValue { get; set; }

    public byte EnabledForJornal { get; set; }
}
