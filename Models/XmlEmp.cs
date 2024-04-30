using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XmlEmp
{
    public string? EpoCode { get; set; }

    public string? EpoLname { get; set; }

    public string? EpoFname { get; set; }

    public string? EpoMname { get; set; }

    public int? EpoSalute { get; set; }

    public int? EpoGender { get; set; }

    public string? EpoBirthdate { get; set; }

    public string? EpoFlag { get; set; }

    public int? EpoStatus { get; set; }
}
