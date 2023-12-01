using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DComment
{
    public int CComment { get; set; }

    public string? CommentKurator { get; set; }

    public string? CommentUser { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();
}
