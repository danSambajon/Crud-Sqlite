using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbCBase
{
    public string? VipCode { get; set; }

    public int? VipHist { get; set; }

    public string? VipDatemodi { get; set; }

    public string? VipSitecode { get; set; }

    public string? VipEmpid { get; set; }

    public string? VipReason { get; set; }

    public string? VipPincode { get; set; }

    public string? VipStatus { get; set; }
}
