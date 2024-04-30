using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XAddon
{
    public int Id { get; set; }

    public int? XTid { get; set; }

    public string? XStamp { get; set; }

    public string? XAccountcode { get; set; }

    public double? XAmountdue { get; set; }

    public string? XRate { get; set; }

    public DateTime? XLastUpdate { get; set; }
}
