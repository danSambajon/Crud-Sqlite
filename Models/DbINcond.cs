using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbINcond
{
    public string? InvItemcode { get; set; }

    public int? InvGroup { get; set; }

    public double? InvMin { get; set; }

    public double? InvMax { get; set; }
}
