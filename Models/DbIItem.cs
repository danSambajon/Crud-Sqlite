using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIItem
{
    public string? InvItemcode { get; set; }

    public string? InvType { get; set; }

    public int? InvModigrp { get; set; }

    public int? InvFlag { get; set; }

    public string? PosTaskcode { get; set; }

    public int? PosFormat { get; set; }
}
