using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPForm
{
    public int? PosCode { get; set; }

    public string? PosName { get; set; }

    public int? PosColor { get; set; }

    public int? PosTop { get; set; }

    public int? PosLeft { get; set; }

    public int? PosWidth { get; set; }

    public int? PosHeight { get; set; }

    public int? PosType { get; set; }

    public string? PosBitmap { get; set; }
}
