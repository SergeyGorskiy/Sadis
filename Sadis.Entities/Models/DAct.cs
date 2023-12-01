using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class DAct
{
    public int CAct { get; set; }

    public int CContract { get; set; }

    public int CMonth { get; set; }

    public string NAct { get; set; } = null!;

    public int Number { get; set; }

    public DateTime DateAct { get; set; }

    public DateTime DateBegin { get; set; }

    public DateTime DateEnd { get; set; }

    public DateTime? DateUpdate { get; set; }

    public DateTime? DateCreate { get; set; }

    public DContract CContractNavigation { get; set; } = null!;

    public DMonth CMonthNavigation { get; set; } = null!;

    public ICollection<DActPlan> DActPlans { get; set; } = new List<DActPlan>();

    public ICollection<DActRegistrationFile> DActRegistrationFiles { get; set; } = new List<DActRegistrationFile>();

    public ICollection<DActRegistration> DActRegistrations { get; set; } = new List<DActRegistration>();

    public ICollection<DActSanction> DActSanctions { get; set; } = new List<DActSanction>();

    public ICollection<DJournal> DJournals { get; set; } = new List<DJournal>();
}
