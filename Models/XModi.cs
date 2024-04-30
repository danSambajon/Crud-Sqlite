using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XModi
{
    public int Id { get; set; }

    public int? XTid { get; set; }

    public int? XItemId { get; set; }

    public string? XStamp { get; set; }

    public string? XTaskcode { get; set; }

    public string? XTasktype { get; set; }

    public string? XApiflag { get; set; }

    public string? XFormat { get; set; }

    public string? XModgroup { get; set; }

    public string? XModsgroup { get; set; }

    public int? XFlag { get; set; }

    public double? XQuantity { get; set; }

    public string? XDescription { get; set; }

    public string? XOwnerstamp { get; set; }

    public string? XOwneritemcodx { get; set; }

    public double? XOwnerqty { get; set; }

    public DateTime? XLastUpdate { get; set; }
}
