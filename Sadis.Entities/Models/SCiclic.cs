using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SCiclic
{
    public int CCiclic { get; set; }

    public int CWorkGroup { get; set; }

    public int CWork { get; set; }

    public int CExplCategory { get; set; }

    public int CClimatZone { get; set; }

    public double? CoefValueWork { get; set; }

    public SClimatZone CClimatZoneNavigation { get; set; } = null!;

    public SExplCategory CExplCategoryNavigation { get; set; } = null!;

    public SWorkGroup CWorkGroupNavigation { get; set; } = null!;

    public SWork CWorkNavigation { get; set; } = null!;

    public ICollection<SCiclicDetail> SCiclicDetails { get; set; } = new List<SCiclicDetail>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
