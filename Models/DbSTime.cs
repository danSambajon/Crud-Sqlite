using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbSTime
{
    public int? CalCode { get; set; }

    public string? CalStime { get; set; }

    public string? CalEtime { get; set; }
}
