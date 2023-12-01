﻿using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWorkResWorker
{
    public int CWorkResWorker { get; set; }

    public int CWork { get; set; }

    public int CResWorker { get; set; }

    public double Value { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public SResWorker CResWorkerNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;
}
