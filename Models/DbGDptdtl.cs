using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbGDptdtl
{
    public int? DptCode { get; set; }

    public int? DptType { get; set; }

    public int? DptGroup { get; set; }

    public int? DptLevel { get; set; }

    public int? DptNode { get; set; }

    public string? DptDescription { get; set; }
}
