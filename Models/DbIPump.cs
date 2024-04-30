using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIPump
{
    public int? InvPump { get; set; }

    public string? InvAuthmode { get; set; }

    public int? InvDelmode { get; set; }
}
