using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DHistoryChange
{
    public int CHistoryChange { get; set; }

    public DateTime DateCreate { get; set; }

    public DateTime Date { get; set; }

    public string Text { get; set; } = null!;

    public bool ShowOnLoginPage { get; set; }
}
