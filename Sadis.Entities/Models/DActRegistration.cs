using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DActRegistration
{
    public int CActRegistration { get; set; }

    public int CAct { get; set; }

    public int CUser { get; set; }

    public string UserDisplayName { get; set; } = null!;

    public DateTime DateRegistration { get; set; }

    public int IsRegistration { get; set; }

    public DAct CActNavigation { get; set; } = null!;
}
