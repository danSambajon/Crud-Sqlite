using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Sqlite.Data;
using Crud_Sqlite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;
using Microsoft.AspNetCore.Http.Features;
using System.Text.RegularExpressions;
using OfficeOpenXml;
using System.IO;
using System.Data;
using OfficeOpenXml.Table;
using System.Diagnostics.CodeAnalysis;
using DocumentFormat.OpenXml.Bibliography;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Crud_Sqlite.Controllers
{
    public class AbnormalityController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        private readonly ILogger<HomeController> _logger;
        public AbnormalityController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _dbcontext = context;
        }

        public List<Abnormalities> Query()
        {
            var query1 = (from x in _dbcontext.XItems
                          join x1 in _dbcontext.XTickets on x.XTid equals x1.Id
                          join x2 in _dbcontext.XFunctions on x.XTid equals x2.XTid
                          where x.XApiflag == "0" &&
                          x2.XFtype == "H" &&
                          x2.XFindex == 12 &&
                          x.XTank != 0 &&
                          x.XPricedb != 0 &&
                          x1.XYear == 2024 &&
                          x1.XMonth == 3 &&
                          x1.XDay == 25
                          select new { x, x1, x2 })
            .AsEnumerable()
            .GroupBy(x => new
            {
                x.x1.XYear,
                x.x1.XMonth,
                x.x1.XDay,
                x.x.XTank,
                x.x.XItemcode,
                x.x.XPump,
                x.x.XNozzle,
                x.x.XPricedb,
                x.x.XStamp,
                x.x1.XOid,
                x.x1.XCorpcode,
                x.x.XOpentotal,
                x.x.XClosetotal,
                x.x1.XSitecode,
                x.x1.XTransaction,
                x.x.XPrice,
                x.x.XAmountDb,
                x.x.XAmount,
                x.x.XAmountPaid,
                x.x.XTotaltype,
                x.x.XQuantity,
                x.x.XDescription,
                x.x.XStampdown,
                x.x1.XStampfi,
                x.x1.XStamplt,
                x.x1.XOname,
                x.x1.XBatch,
                x.x1.XTable,
                x.x1.XTent
            })
            .Select(g => new Crud_Sqlite.Models.Fuels0
            {
                preInTime = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Max(),
                preOutTime = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Min(),
                INV_DATE = new DateTime(g.Key.XYear ?? 1, g.Key.XMonth ?? 1, g.Key.XDay ?? 1).ToString("yyyy-MM-dd"),
                Start = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Max(),
                End = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Min(),
                XStamp = g.Key.XStamp,
                XYear = g.Key.XYear ?? 0,
                XMonth = g.Key.XMonth ?? 0,
                XDay = g.Key.XDay ?? 0,
                XTank = g.Key.XTank ?? 0,
                ItemCode = g.Key.XItemcode,
                XPump = g.Key.XPump ?? 0,
                XNozzle = g.Key.XNozzle ?? 0,
                XPricedb = g.Key.XPricedb ?? 0,
                XOid = g.Key.XOid,
                XCorpcode = g.Key.XCorpcode ?? 0,
                XOpentotal = g.Key.XOpentotal ?? 0,
                XClosetotal = g.Key.XClosetotal ?? 0,
                XSitecode = g.Key.XSitecode ?? 0,
                XTransaction = g.Key.XTransaction ?? 0,
                XPrice = g.Key.XPrice ?? 0,
                XAmountDb = g.Key.XAmountDb ?? 0,
                XAmount = g.Key.XAmount ?? 0,
                Closing = g.Max(x => x.x.XClosetotal ?? 0),
                nozdown = g.Key.XStampdown,
                InTime = g.Select(x => new TimeOnly(ExtractHours(x.x1.XStampfi), ExtractMinutes(x.x1.XStampfi), 0)).Max(), // Get the maximum time among all the records
                OutTime = g.Select(x => new TimeOnly(ExtractHours(x.x1.XStamplt), ExtractMinutes(x.x1.XStamplt), 0)).Min(), // Get the maximum time among all the records
                Liters = g.Max(x => x.x.XClosetotal ?? 0) - g.Min(x => x.x.XOpentotal ?? 0),
                XOname = g.Key.XOname,
                Shift = g.Key.XBatch ?? 0,
                plateno = g.Key.XTable,
                pono = g.Key.XTent,
                Cust = g.Key.XOpentotal == 0 ? 0 : (g.Key.XOpentotal ?? 0),
                Price = g.Average(x => x.x.XPricedb ?? 0),
                Particulars = g.Key.XDescription,
                Calibration = g.Sum(x =>
                {
                    if (g.Key.XAmountPaid == 0.0 && g.Key.XTotaltype == 5.0)
                    { return g.Key.XQuantity ?? 0.0; }
                    else { return 0.0; }
                }),
                Volume = g.Sum(x =>
                {
                    if (g.Key.XAmountPaid > 0.0 && g.Key.XTotaltype < 100.0 && g.Key.XTotaltype != 5)
                    { return g.Key.XQuantity ?? 0.0; }
                    else { return 0.0; }
                }),
                Opening = g.Min(x =>
                {
                    if (g.Key.XOpentotal == 0)
                    { return 0; }
                    else { return g.Key.XOpentotal ?? 0; };
                })
            })
            .OrderBy(x => x.XPump)
            .ThenBy(x => x.Opening);

            var query2 = (from x in _dbcontext.XItems
                          join x1 in _dbcontext.XTickets on x.XTid equals x1.Id
                          join x2 in _dbcontext.XFunctions on x.XTid equals x2.Id
                          join x3 in _dbcontext.XVips on x.XTid equals x3.Id into x3Group
                          from x3Item in x3Group.DefaultIfEmpty()
                          where x.XApiflag == "0" &&
                          x2.XFtype == "H" &&
                          x2.XFindex == 12 &&
                          x.XTank != 0 &&
                          x.XPricedb != 0 &&
                          x1.XYear == 2024 &&
                          x1.XMonth == 3 &&
                          x1.XDay == 25
                          select new { x, x1, x2 })
            .AsEnumerable()
            .GroupBy(x => new
            {
                x.x.XItemcode,
                x.x.XOpentotal,
                x.x.XClosetotal,
                x.x.XPrice,
                x.x.XAmountDb,
                x.x.XAmount,
                x.x.XAmountPaid,
                x.x.XTotaltype,
                x.x.XQuantity,
                x.x.XStampdown,
                x.x1.XStampfi,
                x.x1.XStamplt,
            })
            .Select(g => new Crud_Sqlite.Models.Fuels0
            {
                Price = g.Average(x => x.x.XPricedb ?? 0),
                AmountDB = g.Sum(x => x.x.XAmountDb ?? 0),
                Amount = g.Sum(x => x.x.XAmountPaid ?? 0),
                Closing = g.Max(x => x.x.XClosetotal ?? 0),
                Liters = g.Max(x => x.x.XClosetotal ?? 0) - g.Min(x => x.x.XOpentotal ?? 0),
                hasXOpentotalZero = g.Any(x => g.Key.XOpentotal == 0),
                Cust = g.Key.XOpentotal == 0 ? 0 : (g.Key.XOpentotal ?? 0),
                XAmountPaid = g.Key.XAmountPaid ?? 0,
                XQuantity = g.Key.XQuantity ?? 0,
                XTotaltype = g.Key.XTotaltype ?? 0,
                XStampfi = g.Key.XStampfi,
                XStamplt = g.Key.XStamplt,
                ItemCode = g.Key.XItemcode
            }).OrderBy(x => x.XTank).ThenBy(x => x.XPump);

            var result = from i in query1
                         join s in query2 on i.INV_DATE equals s.INV_DATE into joined
                         from sub in joined.DefaultIfEmpty()
                         select i;

            var currentOpE = result.Select(x => new {
                ParticularsO = x.Particulars,
                Opening = x.Opening,
                XPump = x.XPump
            }).OrderBy(x => x.Opening).Skip(1).ToList();
            var nextClsE = result.Select(x => new {
                Opening = x.Opening,
                ParticularC = x.Particulars,
                Closing = x.Closing,
                XPump = x.XPump
            }).OrderBy(x => x.Closing).ToList();
            var OCDifferenceE = currentOpE.Zip(nextClsE, (op, cls) => new {
                Opening = op.Opening,
                Closing = cls.Closing,
                OpeningP = op.ParticularsO,
                ClosingP = cls.ParticularC,
                XPumpO = op.XPump,
                XPumpC = cls.XPump,
                OCDifference = op.XPump == cls.XPump ? Math.Abs(cls.Closing - op.Opening) : 0
            }).ToList();

            var result2 = result
                .Select((x, index) =>
            new Crud_Sqlite.Models.Abnormalities
            {
                OpeningZip = index < OCDifferenceE.Count ? OCDifferenceE[index].Opening : 0,
                ClosingZip = index < OCDifferenceE.Count ? OCDifferenceE[index].Closing : 0,
                INV_DATE = x.INV_DATE,
                XPump = x.XPump,
                Opening = x.Opening,
                Closing = x.Closing,
                Abnormality = index < OCDifferenceE.Count ? OCDifferenceE[index].OCDifference : 0,
                Short = x.Price * (index < OCDifferenceE.Count ? OCDifferenceE[index].OCDifference : 0),
                Price = x.Price
            }).ToList();

            var resultsList = result2.OrderBy(r => r.XPump).ThenBy(r => r.Opening)
           .Where(abnormality => abnormality.Abnormality > 0)
           .ToList();

            return resultsList;
        }

        [HttpGet]
        public IActionResult Abnormality()
        {
            List<Abnormalities> resultsList = Query();
            return View("Show", resultsList);
        }

        [HttpPost]
        public async Task<IActionResult> Abnormality(int buttonType)
        {
            List<Abnormalities> resultsList = Query();
            var properties = typeof(Abnormalities).GetProperties();
            string headerRow = string.Join(",", properties.Select(p => p.Name));
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine(headerRow);
            foreach (var item in resultsList)
            {
                var itemss = item.GetType().GetProperties();
                var line = string.Join(",", itemss.Select(p => p.GetValue(item)?.ToString() ?? ""));
                csvContent.AppendLine(line);
            }
            string fileName = "Offlines_" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + ".csv";
            Response.Headers.Add("Content-Disposition", $"attachment; filename={ fileName }");
            Response.ContentType = "text/csv";
            byte[] csvBytes = Encoding.UTF8.GetBytes(csvContent.ToString());
            return File(csvBytes, "text/csv");
        }   

        public static int ExtractHours(string input)
        {
            try
            {
                string number = input.Substring(8, 2);
                int hours = int.Parse(number);
                return hours;
            }
            catch (InvalidOperationException)
            {
                int zero = 0;
                return zero;
            }
        }
        public static int ExtractMinutes(string input)
        {
            try
            {
                string number = input.Substring(10, 2);
                int minutes = int.Parse(number);
                return minutes;
            }
            catch (InvalidOperationException)
            {
                int minutes = 0;
                return minutes;
            }
        }

    }
}