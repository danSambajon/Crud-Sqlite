using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPKboard
{
    public int? PosKey { get; set; }

    public int? PosShift { get; set; }

    public string? PosTaskcode { get; set; }

    public int? PosSecurity { get; set; }

    public int? PosFcode { get; set; }

    public int? PosSfcode { get; set; }

    public int? PosFlag { get; set; }
}
