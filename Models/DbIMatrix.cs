using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIMatrix
{
    public string? InvItemcodex { get; set; }

    public string? InvItemcode { get; set; }

    public string? InvBom { get; set; }

    public string? InvUom { get; set; }

    public int? InvFlag { get; set; }

    public int? InvStatus { get; set; }

    public string? InvKind { get; set; }

    public double? InvYield { get; set; }

    public int? InvDrtable { get; set; }

    public double? InvMin { get; set; }

    public double? InvMax { get; set; }

    public double? InvSug { get; set; }
}
