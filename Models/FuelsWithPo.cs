using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models;

public partial class FuelsWithPo
{
    public int Id { get; set; }

    public double Calibration { get; set; }

    public double Closing { get; set; }

    public double Cust { get; set; }

    public string? End { get; set; }

    public string InvDate { get; set; } = null!;

    public string InTime { get; set; } = null!;

    public int IsOffline { get; set; }

    public double Liters { get; set; }

    public double Opening { get; set; }

    public string OutTime { get; set; } = null!;

    public string Particulars { get; set; } = null!;

    public double Price { get; set; }

    public int Shift { get; set; }

    public string? Start { get; set; }

    public int Transcount { get; set; }

    public double Volume { get; set; }

    public double Xamount { get; set; }

    public double XamountDb { get; set; }

    public int Xcorpcode { get; set; }

    public int Xday { get; set; }

    public string? Xitemcode { get; set; }

    public int Xmonth { get; set; }

    public int Xnozzle { get; set; }

    public string Xoid { get; set; } = null!;

    public string Xoname { get; set; } = null!;

    public int Xpump { get; set; }

    public int Xsitecode { get; set; }

    public int Xtank { get; set; }

    public int Xtransaction { get; set; }

    public int Xyear { get; set; }

    public string Nozdown { get; set; } = null!;

    public string Plateno { get; set; } = null!;

    public string Pono { get; set; } = null!;

    public string PreInTime { get; set; } = null!;

    public string PreOutTime { get; set; } = null!;
}
