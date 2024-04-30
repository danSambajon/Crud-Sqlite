using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbGDept
{
    public int? DptCode { get; set; }

    public int? DptType { get; set; }

    public string? DptDescription { get; set; }
}
