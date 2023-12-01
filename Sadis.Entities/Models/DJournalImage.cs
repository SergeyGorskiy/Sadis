using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournalImage
{
    public Guid Guid { get; set; }

    public int CJournal { get; set; }

    public int Status { get; set; }

    public string Type { get; set; } = null!;

    public byte[] Data { get; set; } = null!;

    public string? Filename { get; set; }

    public DJournal CJournalNavigation { get; set; } = null!;
}
