using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbSPeriod
{
    public int? CalCode { get; set; }

    public int? CalInterval { get; set; }

    public int? CalScope { get; set; }
}
