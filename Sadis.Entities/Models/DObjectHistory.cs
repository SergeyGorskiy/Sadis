using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DObjectHistory
{
    public int CObjectHistory { get; set; }

    public int CObject { get; set; }

    public int? CUser { get; set; }

    public DateTime Date { get; set; }

    public DObject CObjectNavigation { get; set; } = null!;
}
