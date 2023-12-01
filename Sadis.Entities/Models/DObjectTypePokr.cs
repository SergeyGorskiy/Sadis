using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DObjectTypePokr
{
    public int CObjectTypePokr { get; set; }

    public int CObject { get; set; }

    public double Begkm { get; set; }

    public double Endkm { get; set; }

    public int CTypePokr { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public DObject CObjectNavigation { get; set; } = null!;

    public STypePokr CTypePokrNavigation { get; set; } = null!;
}
