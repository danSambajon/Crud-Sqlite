using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XFunction
{
    public int Id { get; set; }

    public int? XTid { get; set; }

    public string? XFtype { get; set; }

    public string? XStamp { get; set; }

    public string? XTaskcode { get; set; }

    public string? XTasktype { get; set; }

    public string? XApiflag { get; set; }

    public string? XFormat { get; set; }

    public string? XAccountcode { get; set; }

    public double? XForex { get; set; }

    public string? XCurrsym { get; set; }

    public int? XFindex { get; set; }

    public string? XByte1 { get; set; }

    public string? XByte2 { get; set; }

    public double? XWord1 { get; set; }

    public double? XWord2 { get; set; }

    public double? XDword1 { get; set; }

    public double? XDword2 { get; set; }

    public double? XReal1 { get; set; }

    public double? XReal2 { get; set; }

    public double? XAmount1 { get; set; }

    public double? XAmount2 { get; set; }

    public string? XCkBankname { get; set; }

    public string? XCkCheckno { get; set; }

    public string? XFlag { get; set; }

    public string? XDescription { get; set; }

    public double? XTransactiondue { get; set; }

    public double? XChangedue { get; set; }

    public double? XAmountdue { get; set; }

    public double? XRoundamt { get; set; }

    public double? XTotalamount { get; set; }

    public double? XTotalamountdue { get; set; }

    public string? XGcSerialno { get; set; }

    public string? XCustomfield1 { get; set; }

    public double? XMaxamt { get; set; }

    public double? XMaxqty { get; set; }

    public string? XTstamp { get; set; }

    public double? XUsedamt { get; set; }

    public double? XUsedqty { get; set; }

    public int? XGuestcount { get; set; }

    public int? XSrcount { get; set; }

    public string? XItemcodex { get; set; }

    public int? XControlr { get; set; }

    public int? XControlno { get; set; }

    public double? XAmt1 { get; set; }

    public double? XAmt2 { get; set; }

    public double? XAmt3 { get; set; }

    public double? XQty1 { get; set; }

    public double? XQty2 { get; set; }

    public DateTime? XLastUpdate { get; set; }
}
