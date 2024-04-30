using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIPumpport
{
    public int? InvPump { get; set; }

    public int? InvId { get; set; }

    public string? InvPort { get; set; }

    public int? InvProtocol { get; set; }
}
