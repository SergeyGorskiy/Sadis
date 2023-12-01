using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class ViewObjectElementGroup
{
    public int CElement { get; set; }

    public int CObject { get; set; }

    public double? SumCount { get; set; }

    public double? SumLength { get; set; }

    public string? NUnit { get; set; }

    public int? CRoad { get; set; }

    public int? CContract { get; set; }

    public string? NElement { get; set; }

    public int Fact { get; set; }

    public bool IsActive { get; set; }
}
