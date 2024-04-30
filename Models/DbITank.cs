using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbITank
{
    public int? InvTank { get; set; }

    public string? InvItemcodex { get; set; }

    public int? InvWetid { get; set; }

    public double? InvCap { get; set; }

    public double? InvMax { get; set; }

    public double? InvMin { get; set; }

    public double? InvSug { get; set; }
}
