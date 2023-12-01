using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournalConnection
{
    public int CJournalConnection { get; set; }

    public int CWorkWork { get; set; }

    public double Ratio { get; set; }

    public double JournalRatio { get; set; }

    public byte Edited { get; set; }

    public int? CJournal { get; set; }

    public int? CJournalWork { get; set; }
}
