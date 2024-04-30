using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XItem
{
    public int Id { get; set; }

    public int? XTid { get; set; }

    public double? XAmountPaid { get; set; }

    public double? XAmountDb { get; set; }

    public string? XStamp { get; set; }

    public string? XTaskcode { get; set; }

    public string? XTasktype { get; set; }

    public string? XApiflag { get; set; }

    public string? XFormat { get; set; }

    public string? XItemcode { get; set; }

    public string? XItemtype { get; set; }

    public string? XItemkind { get; set; }

    public string? XModgroup { get; set; }

    public int? XItemflag { get; set; }

    public string? XItemcodex { get; set; }

    public string? XInvcode { get; set; }

    public int? XItemflagx { get; set; }

    public int? XStatus { get; set; }

    public double? XYield { get; set; }

    public int? XDrtable { get; set; }

    public string? XPricecode { get; set; }

    public double? XPrice { get; set; }

    public double? XCut { get; set; }

    public string? XPriceflag { get; set; }

    public double? XPricedb { get; set; }

    public string? XBarcode { get; set; }

    public string? XSerialnumber { get; set; }

    public int? XTotaltype { get; set; }

    public string? XTotaltypename { get; set; }

    public int? XPromoindex { get; set; }

    public int? XRoutecolumn { get; set; }

    public string? XCid { get; set; }

    public string? XCname { get; set; }

    public string? XSid { get; set; }

    public double? XQuantity { get; set; }

    public double? XAmount { get; set; }

    public double? XBaseprice { get; set; }

    public double? XAddon { get; set; }

    public double? XDiscount { get; set; }

    public double? XCoupon { get; set; }

    public string? XControlflag { get; set; }

    public string? XDescription { get; set; }

    public string? XTable { get; set; }

    public double? XPoints { get; set; }

    public int? XPstid { get; set; }

    public int? XGuestcount { get; set; }

    public double? XMaxcond { get; set; }

    public double? XMincond { get; set; }

    public string? XNounflag { get; set; }

    public string? XSeatid { get; set; }

    public int? XPump { get; set; }

    public int? XNozzle { get; set; }

    public int? XTank { get; set; }

    public int? XUom { get; set; }

    public string? XSname { get; set; }

    public double? XClosetotal { get; set; }

    public double? XOpentotal { get; set; }

    public string? XStampup { get; set; }

    public string? XStampdown { get; set; }

    public string? XVehicleplateno { get; set; }

    public string? XVehicletype { get; set; }

    public string? XVipMname { get; set; }

    public string? XVipFname { get; set; }

    public string? XVipLname { get; set; }

    public string? XVipCode { get; set; }

    public string? XVipF01 { get; set; }

    public string? XVipF02 { get; set; }

    public string? XVipF03 { get; set; }

    public string? XVipF04 { get; set; }

    public string? XVipF05 { get; set; }

    public int? XPumpflag { get; set; }

    public double? XAmt1 { get; set; }

    public string? XNzstamp { get; set; }

    public double? XTotalVariance { get; set; }

    public DateTime? XLastUpdate { get; set; }
}
