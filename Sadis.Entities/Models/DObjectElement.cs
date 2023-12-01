using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DObjectElement
{
    public int CObjectElement { get; set; }

    public int CElement { get; set; }

    public int CObject { get; set; }

    public double? Begkm { get; set; }

    public double? Endkm { get; set; }

    public string? BegkmStolb { get; set; }

    public string? EndkmStolb { get; set; }

    public double? Count { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public string? Location { get; set; }

    public string? Notes { get; set; }

    public bool AddedAfterAnalysis { get; set; }

    public DateTime? DateBegin { get; set; }

    public bool IsActive { get; set; }

    public Guid? UniqueValue { get; set; }

    public bool? UseInJournal { get; set; }

    public DateTime? DateTransit { get; set; }

    public SElement CElementNavigation { get; set; } = null!;

    public DObject CObjectNavigation { get; set; } = null!;

    public ICollection<DActSanctionDetail> DActSanctionDetails { get; set; } = new List<DActSanctionDetail>();

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();

    public ICollection<DOverwork> DOverworks { get; set; } = new List<DOverwork>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();
}
