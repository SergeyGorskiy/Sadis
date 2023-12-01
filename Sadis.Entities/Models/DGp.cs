using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DGp
{
    public Guid CGps { get; set; }

    public int CRoad { get; set; }

    public double X { get; set; }

    public double Y { get; set; }

    public double Km { get; set; }

    public double Height { get; set; }

    public double Course { get; set; }

    public byte Goodness { get; set; }

    public DRoad CRoadNavigation { get; set; } = null!;
}
