using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crud_Sqlite.Models;

public partial class Abnormality
{
    [Key]
    public int Id { get; set; }

    public double Abnormality1 { get; set; }

    public double Closing { get; set; }

    public double ClosingZip { get; set; }

    public string InvDate { get; set; } = null!;

    public double Opening { get; set; }

    public double OpeningZip { get; set; }

    public double Price { get; set; }

    public double Short { get; set; }

    public int Xpump { get; set; }
}
