using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlUserinfo
{
    public string? UserCode { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Email { get; set; }

    public string? Webid { get; set; }

    public string? Webpass { get; set; }
}
