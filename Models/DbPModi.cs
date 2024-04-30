using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPModi
{
    public string? PosTaskcode { get; set; }

    public int? PosGroup { get; set; }

    public int? PosSubgroup { get; set; }

    public int? PosFlag { get; set; }
}
