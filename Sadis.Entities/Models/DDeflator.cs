using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DDeflator
{
    public int CDeflator { get; set; }

    public int Year { get; set; }

    public int CContract { get; set; }

    public double Deflator { get; set; }

    public DGeneralContract CContractNavigation { get; set; } = null!;
}
