using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TestReportAnalisy
{
    public int Id { get; set; }

    public DateTime? Pass { get; set; }

    public DateTime? Fail { get; set; }

    public string? Comment { get; set; }

    public int? LevelYear { get; set; }

    public int? LevelMonthBeginId { get; set; }

    public int? LevelMonthEndId { get; set; }

    public int? LevelSelectData { get; set; }

    public int? LevelUseDaydate { get; set; }

    public DateTime? LevelDayBegin { get; set; }

    public DateTime? LevelDayEnd { get; set; }

    public int? OptionsUseItogo { get; set; }

    public int? OptionsPrice { get; set; }

    public int? OptionsUseFactsmeta { get; set; }

    public int? OptionsUseOverplan { get; set; }

    public int? OptionsUseSanction { get; set; }

    public int? OptionsFactSanction { get; set; }

    public int? CValuework { get; set; }

    public int? CNotcontrolledwork { get; set; }

    public int? CControlledwork { get; set; }

    public int? CDeniedwork { get; set; }

    public int? CInactwork { get; set; }

    public int? CAcceptpay { get; set; }

    public string? NGeneralContractor { get; set; }

    public string? NGeneralContract { get; set; }

    public string? NContractor { get; set; }

    public string? NRegion { get; set; }

    public string? NRoad { get; set; }

    public string? NKurator { get; set; }

    public string? NObject { get; set; }

    public string? NTypeObject { get; set; }

    public string? NElement { get; set; }

    public string? NTypeWork { get; set; }

    public string? NResourceType { get; set; }

    public string? NResources { get; set; }

    public string? NWork { get; set; }

    public string? NClimatZone { get; set; }

    public string? NExplCategory { get; set; }

    public string? NSanction { get; set; }

    public string? NReportLink { get; set; }

    public string? NUserName { get; set; }
}
