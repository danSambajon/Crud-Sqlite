using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XTicket
{
    public int Id { get; set; }

    public int? XHqcode { get; set; }

    public string? XTicketId { get; set; }

    public int? XCorpcode { get; set; }

    public int? XSitecode { get; set; }

    public string? XPricecode { get; set; }

    public int? XPstid { get; set; }

    public int? XYear { get; set; }

    public int? XMonth { get; set; }

    public int? XDay { get; set; }

    public string? XStamp { get; set; }

    public int? XBatch { get; set; }

    public int? XSequence { get; set; }

    public int? XTransaction { get; set; }

    public double? XVoidtransaction { get; set; }

    public string? XTable { get; set; }

    public string? XTent { get; set; }

    public int? XGuestcount { get; set; }

    public string? XSrcount { get; set; }

    public string? XOid { get; set; }

    public string? XOname { get; set; }

    public int? XShift { get; set; }

    public string? XFlag { get; set; }

    public int? XTotaltype { get; set; }

    public string? XTotaltypename { get; set; }

    public int? XPromoindex { get; set; }

    public int? XRoutecolumn { get; set; }

    public string? XStampfi { get; set; }

    public string? XStamplt { get; set; }

    public string? XOdometer { get; set; }

    public string? XPropertytag { get; set; }

    public int? XDiscountmethod { get; set; }

    public string? XFld001 { get; set; }

    public int? XRsn { get; set; }

    public int? XRtn { get; set; }

    public DateTime? XLastUpdate { get; set; }
}
