using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPHrlyd
{
    public int? PosCode { get; set; }

    public int? PosSequence { get; set; }

    public string? PosDescription { get; set; }

    public string? PosFrom { get; set; }

    public string? PosTo { get; set; }
}
