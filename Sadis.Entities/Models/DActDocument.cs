using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DActDocument
{
    public int CActDocument { get; set; }

    public int CAct { get; set; }

    public string? Name { get; set; }

    public DateTime DateCreate { get; set; }

    public DateTime DateUpdate { get; set; }

    public int CUser { get; set; }

    public double? ActSum { get; set; }
}
