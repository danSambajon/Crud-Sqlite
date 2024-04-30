using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class DbIPrcsch
{
    public int? InvPricecode { get; set; }

    public string? InvDescription { get; set; }

    public string? InvScheme { get; set; }

    public string? InvFlag { get; set; }
}
