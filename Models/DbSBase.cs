using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbSBase
{
    public int? CalCode { get; set; }

    public string? CalName { get; set; }

    public string? CalSdate { get; set; }

    public string? CalEdate { get; set; }

    public int? CalFlag { get; set; }
}
