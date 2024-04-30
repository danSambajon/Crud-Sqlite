using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIPrice
{
    public string? InvItemcodex { get; set; }

    public int? InvPricecode { get; set; }

    public double? InvPrice { get; set; }

    public double? InvCut { get; set; }

    public string? InvFlag { get; set; }
}
