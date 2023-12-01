using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class SWork
{
    public int CWork { get; set; }

    public string NWork { get; set; } = null!;

    public int CUnit { get; set; }

    public string? Code { get; set; }

    public double? CostMaterial { get; set; }

    public double? CostMaterialNow { get; set; }

    public double? CostExpl { get; set; }

    public double? CostExplNow { get; set; }

    public double? SalaryMachine { get; set; }

    public double? SalaryMachineNow { get; set; }

    public double? GeneralSalary { get; set; }

    public double? GeneralSalaryNow { get; set; }

    public double PeriodRepeat { get; set; }

    public int? Kind { get; set; }

    public int? AisWorkGroup { get; set; }

    public int? CheckGroup { get; set; }

    public int? UseDetail { get; set; }

    public bool? UseInDetailsReport { get; set; }

    public bool IsMinus { get; set; }

    public bool MainWork { get; set; }

    public SUnit CUnitNavigation { get; set; } = null!;

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();

    public ICollection<DOverwork> DOverworks { get; set; } = new List<DOverwork>();

    public ICollection<DSubcontractorWork> DSubcontractorWorks { get; set; } = new List<DSubcontractorWork>();

    public ICollection<DVirtualObjectWork> DVirtualObjectWorks { get; set; } = new List<DVirtualObjectWork>();

    public ICollection<SCiclic> SCiclics { get; set; } = new List<SCiclic>();

    public ICollection<SWorkDetail> SWorkDetails { get; set; } = new List<SWorkDetail>();

    public ICollection<SWorkResMachinist> SWorkResMachinists { get; set; } = new List<SWorkResMachinist>();

    public ICollection<SWorkResMaterial> SWorkResMaterials { get; set; } = new List<SWorkResMaterial>();

    public ICollection<SWorkResMechanism> SWorkResMechanisms { get; set; } = new List<SWorkResMechanism>();

    public ICollection<SWorkResWorker> SWorkResWorkers { get; set; } = new List<SWorkResWorker>();

    public ICollection<TempSmetum> TempSmeta { get; set; } = new List<TempSmetum>();

    public ICollection<TempSmetaPlan> TempSmetaPlans { get; set; } = new List<TempSmetaPlan>();
}
