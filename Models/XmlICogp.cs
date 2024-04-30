using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlICogp
{
    public int? InvPump { get; set; }

    public int? InvNozzle { get; set; }

    public int? InvTank { get; set; }

    public string? InvItemcodex { get; set; }

    public double? InvIsuqty { get; set; }

    public double? InvIsuamt { get; set; }

    public double? InvTlzclo { get; set; }

    public double? InvTlzope { get; set; }

    public int? Corpcode { get; set; }

    public int? Sitecode { get; set; }

    public int? Byear { get; set; }

    public int? Bmonth { get; set; }

    public int? Bday { get; set; }
}
