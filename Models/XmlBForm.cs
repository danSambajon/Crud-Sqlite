using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlBForm
{
    public int? EpoCode { get; set; }

    public string? EpoName { get; set; }

    public int? EpoColor { get; set; }

    public string? EpoBitmap { get; set; }
}
