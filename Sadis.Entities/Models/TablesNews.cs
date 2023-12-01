using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesNews
{
    public int CNews { get; set; }

    public string NNews { get; set; } = null!;

    public byte[] Image { get; set; } = null!;

    public string Text { get; set; } = null!;

    public byte Enabled { get; set; }

    public DateTime DateBegin { get; set; }

    public DateTime DateEnd { get; set; }
}
