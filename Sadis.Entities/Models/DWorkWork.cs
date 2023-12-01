using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DWorkWork
{
    public int CWorkWork { get; set; }

    public int CWorkMain { get; set; }

    public int CWork { get; set; }

    public double Ratio { get; set; }

    public double? JournalRatio { get; set; }

    public byte Edited { get; set; }

    public int? CJournal { get; set; }
}
