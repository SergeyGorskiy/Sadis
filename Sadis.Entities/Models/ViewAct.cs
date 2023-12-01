using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class ViewAct
{
    public int CAct { get; set; }

    public string NAct { get; set; } = null!;

    public int CMonth { get; set; }

    public string? NMonth { get; set; }

    public int? Year { get; set; }

    public int CContract { get; set; }
}
