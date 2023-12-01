using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DWebinar
{
    public int CWebinar { get; set; }

    public string NWebinar { get; set; } = null!;

    public string ImgPath { get; set; } = null!;

    public string VideoPath { get; set; } = null!;

    public DateTime Date { get; set; }
}
