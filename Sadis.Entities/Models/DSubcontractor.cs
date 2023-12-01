using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DSubcontractor
{
    public int CSubcontractor { get; set; }

    public string NSubcontractor { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public ICollection<DMaker> DMakers { get; set; } = new List<DMaker>();

    public ICollection<DSubcontractorWork> DSubcontractorWorks { get; set; } = new List<DSubcontractorWork>();
}
