﻿using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIBuom
{
    public string? InvCode { get; set; }

    public string? InvItemcodex { get; set; }

    public int? InvUom { get; set; }

    public double? InvFactor { get; set; }
}