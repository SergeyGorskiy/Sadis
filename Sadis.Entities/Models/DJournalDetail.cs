using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournalDetail
{
    public int CJournalDetail { get; set; }

    public int CJournal { get; set; }

    public double Begkm { get; set; }

    public double Endkm { get; set; }

    public double Value { get; set; }

    public string? Comment { get; set; }

    public DJournal CJournalNavigation { get; set; } = null!;
}
