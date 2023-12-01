using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DDeflatorUser
{
    public int CDeflatorUser { get; set; }

    public int Year { get; set; }

    public int CContract { get; set; }

    public double Deflator { get; set; }

    public DContract CContractNavigation { get; set; } = null!;
}
