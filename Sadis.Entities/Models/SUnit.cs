using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SUnit
{
    public int CUnit { get; set; }

    public string NUnit { get; set; } = null!;

    public string? NameUnit { get; set; }

    public int Comma { get; set; }

    public ICollection<DVirtualObject> DVirtualObjects { get; set; } = new List<DVirtualObject>();

    public ICollection<SElement> SElements { get; set; } = new List<SElement>();

    public ICollection<SResMachinist> SResMachinists { get; set; } = new List<SResMachinist>();

    public ICollection<SResMaterial> SResMaterials { get; set; } = new List<SResMaterial>();

    public ICollection<SResMechanism> SResMechanisms { get; set; } = new List<SResMechanism>();

    public ICollection<SResWorker> SResWorkers { get; set; } = new List<SResWorker>();

    public ICollection<SWork> SWorks { get; set; } = new List<SWork>();
}
