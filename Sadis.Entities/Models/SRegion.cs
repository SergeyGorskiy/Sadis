using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SRegion
{
    public int CRegion { get; set; }

    public string NRegion { get; set; } = null!;

    public double CoefSalary { get; set; }

    public double CoefRegion { get; set; }

    public double CoefArea { get; set; }

    public int COkrug { get; set; }

    public int CClimatZone { get; set; }

    public SClimatZone CClimatZoneNavigation { get; set; } = null!;

    public SOkrug COkrugNavigation { get; set; } = null!;

    public ICollection<DContractorRegion> DContractorRegions { get; set; } = new List<DContractorRegion>();

    public ICollection<DObject> DObjects { get; set; } = new List<DObject>();

    public ICollection<DWeather> DWeathers { get; set; } = new List<DWeather>();

    public ICollection<TempSelectedObject> TempSelectedObjects { get; set; } = new List<TempSelectedObject>();
}
