using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbMaster
{
    public string? Code { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public int? Group { get; set; }

    public string? Barcode { get; set; }

    public double? Cost { get; set; }

    public double? Qty { get; set; }
}
