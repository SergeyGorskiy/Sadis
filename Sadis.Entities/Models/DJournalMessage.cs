using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DJournalMessage
{
    public int CJournalMessage { get; set; }

    public int CJournal { get; set; }

    public int CTypeMessage { get; set; }

    public string MessageText { get; set; } = null!;

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public Guid? ImageGuid { get; set; }

    public DJournal CJournalNavigation { get; set; } = null!;

    public STypeMessage CTypeMessageNavigation { get; set; } = null!;
}
