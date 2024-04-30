using ClosedXML.Excel;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crud_Sqlite.Models
{
    public class Abnormalities
    {
        [Key]
        public int Id { get; set; }
        public double OpeningZip { get; set; }
        public double ClosingZip { get; set; }
        public double Abnormality { get; set; }
        public double Short { get; set; }
        public string INV_DATE { get; set; }
        public int XPump { get; set; }
        public double Opening { get; set; }
        public double Closing { get; set; }
        public double Price { get; set; }
    }
}