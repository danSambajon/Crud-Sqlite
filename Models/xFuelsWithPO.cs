using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Crud_Sqlite.Models
{
    public class xFuelsWithPO
    {
        [Key]
        public int Id { get; set; }
        public TimeOnly? Start { get; set; }
        public TimeOnly? End { get; set; }
        public string INV_DATE { get; set; }
        public int XCorpcode { get; set; }
        public int XSitecode { get; set; }
        public int XTank { get; set; }
        public int XPump { get; set; }
        public int XNozzle { get; set; }
        public int XYear { get; set; }
        public int XMonth { get; set; }
        public int XDay { get; set; }
        public int XTransaction { get; set; }
        public double Price { get; set; }
        public double XAmountDb { get; set; }
        public double XAmount { get; set; }
        public double Calibration { get; set; }
        public double Volume { get; set; }
        public string? XItemcode { get; set; }
        public string Particulars { get; set; }
        public double Opening { get; set; }
        public double Closing { get; set; }
        public string nozdown { get; set; }
        public TimeOnly preInTime { get; set; }
        public TimeOnly InTime { get; set; }
        public TimeOnly preOutTime { get; set; }
        public TimeOnly OutTime { get; set; }
        public double Liters { get; set; }
        public string XOid { get; set; }
        public string XOname { get; set; }
        public int Shift { get; set; }
        public string plateno { get; set; }
        public string pono { get; set; }
        public double Cust { get; set; }
        public int Transcount { get; set; }
    }
}