using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class STypeMessage
{
    public int CTypeMessage { get; set; }

    public string NTypeMessage { get; set; } = null!;

    public ICollection<DJournalMessage> DJournalMessages { get; set; } = new List<DJournalMessage>();
}
