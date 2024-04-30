using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbPButton
{
    public int? PosCode { get; set; }

    public int? PosLeft { get; set; }

    public int? PosTop { get; set; }

    public int? PosHeight { get; set; }

    public int? PosWidth { get; set; }

    public string? PosTaskcode { get; set; }

    public int? PosSecurity { get; set; }

    public string? PosText { get; set; }

    public int? PosColor { get; set; }

    public int? PosFntcolor { get; set; }

    public string? PosFntname { get; set; }

    public int? PosFntsize { get; set; }

    public int? PosFntstyle { get; set; }

    public int? PosFcode { get; set; }

    public int? PosSfcode { get; set; }

    public string? PosBitmap { get; set; }

    public int? PosFlag { get; set; }
}
