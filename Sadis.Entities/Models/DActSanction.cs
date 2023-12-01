using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DActSanction
{
    public int CActSanction { get; set; }

    public int CAct { get; set; }

    public string NActSanction { get; set; } = null!;

    public int? CUser { get; set; }

    public string? UserDisplayName { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public DAct CActNavigation { get; set; } = null!;
}
