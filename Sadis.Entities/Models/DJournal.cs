using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournal
{
    public int CJournal { get; set; }

    public int CObjectElement { get; set; }

    public int CWork { get; set; }

    public int CMaker { get; set; }

    public int? CAct { get; set; }

    public int CWorkType { get; set; }

    public DateTime Date { get; set; }

    public double Value { get; set; }

    public double? Begkm { get; set; }

    public double? Endkm { get; set; }

    public byte IsControlled { get; set; }

    public double? CostoneworkNow { get; set; }

    public double? FotValueNow { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? CComment { get; set; }

    public int? IsAis { get; set; }

    public int? ControlledCAct { get; set; }

    public int CObjectContract { get; set; }

    public int? Weather { get; set; }

    public int? AisTemperature { get; set; }

    public int? CUser { get; set; }

    public int? CWeather { get; set; }

    public double? PlanValueMonth { get; set; }

    public double? PlanValueYear { get; set; }

    public byte PlanIsCalc { get; set; }

    public int? CMonth { get; set; }

    public int? CKurator { get; set; }

    public string? KuratorName { get; set; }

    public int? COverworkDetail { get; set; }

    public byte IsDenied { get; set; }

    public DAct? CActNavigation { get; set; }

    public DComment? CCommentNavigation { get; set; }

    public DMaker CMakerNavigation { get; set; } = null!;

    public DObjectContract CObjectContractNavigation { get; set; } = null!;

    public DObjectElement CObjectElementNavigation { get; set; } = null!;

    public DWeather? CWeatherNavigation { get; set; }

    public SWork CWorkNavigation { get; set; } = null!;

    public ICollection<DJournalDetail> DJournalDetails { get; set; } = new List<DJournalDetail>();

    public ICollection<DJournalImage> DJournalImages { get; set; } = new List<DJournalImage>();

    public ICollection<DJournalMessage> DJournalMessages { get; set; } = new List<DJournalMessage>();

    public ICollection<DJournalVehicle> DJournalVehicles { get; set; } = new List<DJournalVehicle>();

    public ICollection<DJournalWebApi> DJournalWebApis { get; set; } = new List<DJournalWebApi>();
}
