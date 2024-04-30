using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlIIfifo
{
    public string? InvStamp { get; set; }

    public int? InvPos { get; set; }

    public int? InvSource { get; set; }

    public string? InvAccount { get; set; }

    public string? InvItemcodex { get; set; }

    public double? InvQty { get; set; }

    public double? InvAmt { get; set; }

    public double? InvUsed { get; set; }

    public int? Corpcode { get; set; }

    public int? Sitecode { get; set; }

    public int? Byear { get; set; }

    public int? Bmonth { get; set; }

    public int? Bday { get; set; }
}
