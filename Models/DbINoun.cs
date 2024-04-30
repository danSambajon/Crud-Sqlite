using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbINoun
{
    public string? InvItemcode { get; set; }

    public double? InvMin { get; set; }

    public double? InvMax { get; set; }

    public int? InvFlag { get; set; }
}
