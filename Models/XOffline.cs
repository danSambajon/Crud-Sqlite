using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class XOffline
{
    public int Id { get; set; }

    public DateOnly? XBdate { get; set; }

    public int? XBatch { get; set; }

    public string? XCashier { get; set; }

    public string? XCashierCode { get; set; }

    public int? XBeforeInvoice { get; set; }

    public int? XAfterInvoice { get; set; }

    public string? XItemCode { get; set; }

    public string? XItemName { get; set; }

    public double? XQuantity { get; set; }

    public double? XAmount { get; set; }

    public double? XUnitPrice { get; set; }

    public int? XTankNo { get; set; }

    public int? XPumpNo { get; set; }

    public int? XNozzle { get; set; }

    public double? XOpenTotalizer { get; set; }

    public double? XCloseTotalizer { get; set; }

    public double? XOrigOpenTotal { get; set; }

    public int? XTotalType { get; set; }

    public DateTime? XBeforeStamp { get; set; }

    public DateTime? XAfterStamp { get; set; }
}
