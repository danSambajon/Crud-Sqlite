using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPPmap
{
    public string? PosHqcode { get; set; }

    public string? PosSitecode { get; set; }

    public int? PosPstid { get; set; }

    public int? PosIndex { get; set; }

    public string? PosTaskcode { get; set; }
}
