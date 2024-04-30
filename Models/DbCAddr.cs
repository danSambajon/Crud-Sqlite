using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbCAddr
{
    public string? VipCode { get; set; }

    public int? VipHist { get; set; }

    public string? VipHseno { get; set; }

    public string? VipStreet { get; set; }

    public string? VipBario { get; set; }

    public string? VipCity { get; set; }

    public string? VipZip { get; set; }

    public string? VipPhone { get; set; }
}
