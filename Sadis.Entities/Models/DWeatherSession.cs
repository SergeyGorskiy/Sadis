using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DWeatherSession
{
    public Guid CWeatherSession { get; set; }

    public DateTime DateCreate { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public int? CRegion { get; set; }

    public string Message { get; set; } = null!;

    public Guid CQuery { get; set; }

    public int? CObject { get; set; }

    public ICollection<DWeather> DWeathers { get; set; } = new List<DWeather>();
}
