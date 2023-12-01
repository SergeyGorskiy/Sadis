using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DApiToken
{
    public Guid CApiToken { get; set; }

    public int CUser { get; set; }

    public int CContractor { get; set; }

    public string DeviceId { get; set; } = null!;

    public DateTime LastActivity { get; set; }

    public DateTime EntityMakers { get; set; }

    public DateTime EntityElements { get; set; }

    public DateTime EntityUnits { get; set; }

    public DateTime EntityWorks { get; set; }

    public DateTime EntityGps { get; set; }

    public DateTime EntityRoads { get; set; }

    public DateTime EntityObjects { get; set; }

    public DateTime EntityObjectElements { get; set; }

    public DateTime EntityContracts { get; set; }

    public DContractor CContractorNavigation { get; set; } = null!;
}
