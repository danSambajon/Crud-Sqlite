using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlICogt
{
    public int? InvTank { get; set; }

    public string? InvItemcodex { get; set; }

    public int? InvBatch { get; set; }

    public double? InvBegqty { get; set; }

    public double? InvBegamt { get; set; }

    public double? InvEndqty { get; set; }

    public double? InvEndamt { get; set; }

    public double? InvDelqty { get; set; }

    public double? InvDelamt { get; set; }

    public double? InvAcudelqty { get; set; }

    public double? InvAcudelamt { get; set; }

    public double? InvIsuqty { get; set; }

    public double? InvIsuamt { get; set; }

    public double? InvAcuisuqty { get; set; }

    public double? InvAcuisuamt { get; set; }

    public double? InvVarqty { get; set; }

    public double? InvVaramt { get; set; }

    public double? InvWtrqty { get; set; }

    public double? InvWtramt { get; set; }

    public double? InvCostlast { get; set; }

    public double? InvCostma { get; set; }

    public int? Corpcode { get; set; }

    public int? Sitecode { get; set; }

    public int? Byear { get; set; }

    public int? Bmonth { get; set; }

    public int? Bday { get; set; }
}
