using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournalVehicle
{
    public int CJournalVehicle { get; set; }

    public int CJournal { get; set; }

    public int? VehicleId { get; set; }

    public string VehicleName { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public DJournal CJournalNavigation { get; set; } = null!;
}
