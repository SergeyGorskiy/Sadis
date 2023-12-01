using System;
using System.Collections.Generic;

namespace Sadis.Entities.Models;

public class TablesUser
{
    public int CUser { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? CContractor { get; set; }

    public int? CGeneralContractor { get; set; }

    public string DisplayName { get; set; } = null!;

    public byte? Enabled { get; set; }

    public DateTime? DatePasp { get; set; }

    public int CRole { get; set; }

    public DContractor? CContractorNavigation { get; set; }

    public DGeneralContractor? CGeneralContractorNavigation { get; set; }

    public TablesRole CRoleNavigation { get; set; } = null!;
}
