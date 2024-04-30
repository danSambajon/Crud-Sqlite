using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIBom
{
    public string? InvCode { get; set; }

    public string? InvDescription { get; set; }

    public double? InvYield { get; set; }

    public string? InvKind { get; set; }
}
