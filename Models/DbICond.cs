using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbICond
{
    public string? InvItemcode { get; set; }

    public int? InvGroup { get; set; }

    public int? InvFlag { get; set; }
}
