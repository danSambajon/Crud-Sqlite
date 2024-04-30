using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPError
{
    public int? PosCode { get; set; }

    public int? PosNamecode { get; set; }

    public string? PosShortmsg { get; set; }

    public string? PosMessage { get; set; }
}
