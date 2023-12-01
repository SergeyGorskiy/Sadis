using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournalWebApi
{
    public int CJournal { get; set; }

    public Guid Guid { get; set; }

    public DJournal CJournalNavigation { get; set; } = null!;
}
