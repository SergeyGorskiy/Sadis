using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DNakrutki
{
    public int CNakrutki { get; set; }

    public string NNakrutki { get; set; } = null!;

    public double PercentValue { get; set; }

    public int Sort { get; set; }
}
