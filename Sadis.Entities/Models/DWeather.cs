using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DWeather
{
    public int CWeather { get; set; }

    public int? CRegion { get; set; }

    public DateTime Date { get; set; }

    public string? WindDirection { get; set; }

    public string? WeatherType { get; set; }

    public double Precipitation { get; set; }

    public double Temperature { get; set; }

    public double TemperatureMin { get; set; }

    public double TemperatureMax { get; set; }

    public Guid CWeatherSession { get; set; }

    public int? CObject { get; set; }

    public DObject? CObjectNavigation { get; set; }

    public SRegion? CRegionNavigation { get; set; }

    public DWeatherSession CWeatherSessionNavigation { get; set; } = null!;

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();
}
