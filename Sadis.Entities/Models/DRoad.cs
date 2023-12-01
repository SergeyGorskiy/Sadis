using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DRoad
{
    public int CRoad { get; set; }

    public string NRoad { get; set; } = null!;

    public string? Code { get; set; }

    public double? Begkm { get; set; }

    public double? Endkm { get; set; }

    public DateTime? DateActualization { get; set; }

    public Guid UniqueValue { get; set; }

    public byte EnabledForJornal { get; set; }

    public int SortIndex { get; set; }

    public ICollection<DDeviceSession> DDeviceSessions { get; set; } = new List<DDeviceSession>();

    public ICollection<DGp> DGps { get; set; } = new List<DGp>();

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
