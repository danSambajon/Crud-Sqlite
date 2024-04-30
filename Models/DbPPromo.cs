using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPPromo
{
    public string? PosAccount { get; set; }

    public string? PosType { get; set; }

    public string? InvItemcodex { get; set; }

    public double? PosQty { get; set; }

    public double? PosAmt { get; set; }

    public double? PosRate { get; set; }

    public int? DptCode { get; set; }

    public int? DptGroup { get; set; }
}
