using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class ViewObjectElement
{
    public int CObjectElement { get; set; }

    public int CElement { get; set; }

    public int CObject { get; set; }

    public double? SumCount { get; set; }

    public double? SumLength { get; set; }

    public string? NUnit { get; set; }

    public int? CRoad { get; set; }

    public int? CContract { get; set; }

    public double? Begkm { get; set; }

    public double? Endkm { get; set; }

    public string? Caption { get; set; }

    public bool AddedAfterAnalysis { get; set; }
}
