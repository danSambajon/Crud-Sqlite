using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIBomdtl
{
    public string? InvCode { get; set; }

    public string? InvItemcodex { get; set; }

    public int? InvUom { get; set; }

    public double? InvQty { get; set; }

    public int? InvFlag { get; set; }

    public double? InvUsage { get; set; }
}
