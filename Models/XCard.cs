using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XCard
{
    public int Id { get; set; }

    public int? XTid { get; set; }

    public string? XMcAccount { get; set; }

    public string? XMcAmtbal { get; set; }

    public string? XMcCardname { get; set; }

    public string? XMcCardno { get; set; }

    public string? XMcCorpcode { get; set; }

    public string? XMcDatetime { get; set; }

    public string? XMcDaylimit { get; set; }

    public string? XMcExpire { get; set; }

    public string? XMcFlag { get; set; }

    public string? XMcLimit { get; set; }

    public string? XMcPdatetime { get; set; }

    public string? XMcPsitecode { get; set; }

    public string? XMcPump { get; set; }

    public string? XMcPvalue { get; set; }

    public string? XMcPxtype { get; set; }

    public string? XMcReqvalue { get; set; }

    public string? XMcSeries { get; set; }

    public string? XMcSitecode { get; set; }

    public string? XMcValue { get; set; }

    public string? XMcVersion { get; set; }

    public string? XMcVolbal { get; set; }

    public string? XMcXtype { get; set; }

    public DateTime? XLastUpdate { get; set; }
}
