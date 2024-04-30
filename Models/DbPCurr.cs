using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPCurr
{
    public int? PosCode { get; set; }

    public string? PosSym { get; set; }

    public double? PosRate { get; set; }
}
