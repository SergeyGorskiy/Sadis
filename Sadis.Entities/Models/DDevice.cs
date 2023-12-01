using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DDevice
{
    public string CDevice { get; set; } = null!;

    public int? CUser { get; set; }

    public ICollection<DDeviceSession> DDeviceSessions { get; set; } = new List<DDeviceSession>();
}
