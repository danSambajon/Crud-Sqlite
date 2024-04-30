using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlBTask
{
    public string? EpoTaskcode { get; set; }

    public int? EpoTasktype { get; set; }

    public string? EpoCommand { get; set; }
}
