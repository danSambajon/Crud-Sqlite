//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Threading;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Crud_Sqlite.Data;
//using Crud_Sqlite.Models;
//using Newtonsoft.Json.Linq;
//using System.Globalization;
//using System.Text;
//using Microsoft.Extensions.Caching.Memory;
//using Crud_Sqlite.Migrations;
//using DocumentFormat.OpenXml.Office2010.ExcelAc;

//namespace Crud_Sqlite.Controllers
//{
//    public class FuelsController : Controller
//    {
//        private readonly JournalContext _context;
//        private readonly ApplicationDbContext _dbcontext;
//        private readonly ILogger<FuelsController> _logger;
//        private readonly IMemoryCache _memoryCache;
//        public FuelsController(ILogger<FuelsController> logger, ApplicationDbContext context, IMemoryCache memoryCache)
//        {
//            _logger = logger;
//            _dbcontext = context;
//            _memoryCache = memoryCache;
//        }

//        public List<xFuelsWithPO> Query()
//        {
//            var resultsList = new List<xFuelsWithPO>();

//            var query1 = (from x in _dbcontext.XItems
//                          join x1 in _dbcontext.XTickets on x.XTid equals x1.Id
//                          join x2 in _dbcontext.XFunctions on x.XTid equals x2.XTid
//                          where x.XApiflag == "0" &&
//                          x2.XFtype == "H" &&
//                          x2.XFindex == 12 &&
//                          x.XTank != 0 &&
//                          x.XPricedb != 0 &&
//                          x1.XYear == 2024 &&
//                          x1.XMonth == 3 &&
//                          x1.XDay == 25
//                          //((x1.XYear == DateTime.Today.Year - 1 && x1.XMonth == 12 && x1.XDay >= 1) ||  // Items from December 1st of last year
//                          // (x1.XYear == DateTime.Today.Year && x1.XMonth == DateTime.Today.Month && x1.XDay <= DateTime.Today.Day - 1) // Items from this year up to today
//                          select new { x, x1, x2 })
//        .AsEnumerable()
//        .GroupBy(x => new
//        {
//            x.x1.XYear,
//            x.x1.XMonth,
//            x.x1.XDay,
//            x.x.XTank,
//            x.x.XItemcode,
//            x.x.XPump,
//            x.x.XNozzle,
//            x.x.XPricedb,
//            x.x.XStamp,
//            x.x1.XOid,
//            x.x1.XCorpcode,
//            x.x.XOpentotal,
//            x.x.XClosetotal,
//            x.x1.XSitecode,
//            x.x1.XTransaction,
//            x.x.XPrice,
//            x.x.XAmountDb,
//            x.x.XAmount,
//            x.x.XAmountPaid,
//            x.x.XTotaltype,
//            x.x.XQuantity,
//            x.x.XDescription,
//            x.x.XStampdown,
//            x.x1.XStampfi,
//            x.x1.XStamplt,
//            x.x1.XOname,
//            x.x1.XBatch,
//            x.x1.XTable,
//            x.x1.XTent,
//        })
//        .Select(g => new Crud_Sqlite.Models.Fuels0
//        {
//            preInTime = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Max(),
//            preOutTime = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Min(),
//            INV_DATE = new DateTime(g.Key.XYear ?? 1, g.Key.XMonth ?? 1, g.Key.XDay ?? 1).ToString("yyyy-MM-dd"),
//            Start = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Max(), // Get the maximum time among all the records
//            End = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Min(),
//            XStamp = g.Key.XStamp,
//            XYear = g.Key.XYear ?? 0,
//            XMonth = g.Key.XMonth ?? 0,
//            XDay = g.Key.XDay ?? 0,
//            XTank = g.Key.XTank ?? 0,
//            ItemCode = g.Key.XItemcode,
//            XPump = g.Key.XPump ?? 0,
//            XNozzle = g.Key.XNozzle ?? 0,
//            XPricedb = g.Key.XPricedb ?? 0,
//            XOid = g.Key.XOid,
//            XCorpcode = g.Key.XCorpcode ?? 0,
//            XOpentotal = g.Key.XOpentotal ?? 0,
//            XClosetotal = g.Key.XClosetotal ?? 0,
//            XSitecode = g.Key.XSitecode ?? 0,
//            XTransaction = g.Key.XTransaction ?? 0,
//            XPrice = g.Key.XPrice ?? 0,
//            XAmountDb = g.Key.XAmountDb ?? 0,
//            XAmount = g.Key.XAmount ?? 0,
//            Closing = g.Max(x => x.x.XClosetotal ?? 0),
//            nozdown = g.Key.XStampdown,
//            InTime = g.Select(x => new TimeOnly(ExtractHours(x.x1.XStampfi), ExtractMinutes(x.x1.XStampfi), 0)).Max(), // Get the maximum time among all the records
//            OutTime = g.Select(x => new TimeOnly(ExtractHours(x.x1.XStamplt), ExtractMinutes(x.x1.XStamplt), 0)).Min(), // Get the maximum time among all the records
//            Liters = g.Max(x => x.x.XClosetotal ?? 0) - g.Min(x => x.x.XOpentotal ?? 0),
//            XOname = g.Key.XOname,
//            Shift = g.Key.XBatch ?? 0,
//            plateno = g.Key.XTable,
//            pono = g.Key.XTent,
//            Cust = g.Key.XOpentotal == 0 ? 0 : (g.Key.XOpentotal ?? 0),
//            Price = g.Average(x => x.x.XPricedb ?? 0),
//            Particulars = g.Key.XDescription,
//            Calibration = g.Sum(x =>
//            {
//                if (g.Key.XAmountPaid == 0.0 && g.Key.XTotaltype == 5.0)
//                { return g.Key.XQuantity ?? 0.0; }
//                else { return 0.0; }
//            }),
//            Volume = g.Sum(x =>
//            {
//                if (g.Key.XAmountPaid > 0.0 && g.Key.XTotaltype < 100.0 && g.Key.XTotaltype != 5)
//                { return g.Key.XQuantity ?? 0.0; }
//                else { return 0.0; }
//            }),
//            Opening = g.Min(x =>
//            {
//                if (g.Key.XOpentotal == 0)
//                { return 0; }
//                else { return g.Key.XOpentotal ?? 0; };
//            })
//        })
//        .OrderBy(x => x.XPump)
//        .ThenBy(x => x.Opening);

//            var query2 = (from x in _dbcontext.XItems
//                          join x1 in _dbcontext.XTickets on x.XTid equals x1.Id
//                          join x2 in _dbcontext.XFunctions on x.XTid equals x2.Id
//                          join x3 in _dbcontext.XVips on x.XTid equals x3.Id into x3Group
//                          from x3Item in x3Group.DefaultIfEmpty()
//                          where x.XApiflag == "0" &&
//                          x2.XFtype == "H" &&
//                          x2.XFindex == 12 &&
//                          x.XTank != 0 &&
//                          x.XPricedb != 0 &&
//                          x1.XYear == 2024 &&
//                          x1.XMonth == 3 &&
//                          x1.XDay == 25
//                          //((x1.XYear == DateTime.Today.Year - 1 && x1.XMonth == 12 && x1.XDay >= 1) ||  // Items from December 1st of last year
//                          // (x1.XYear == DateTime.Today.Year && x1.XMonth == DateTime.Today.Month && x1.XDay <= DateTime.Today.Day-1) // Items from this year up to today
//                          select new { x, x1, x2 })
//            .AsEnumerable()
//            .GroupBy(x => new
//            {
//                x.x.XItemcode,
//                x.x.XOpentotal,
//                x.x.XClosetotal,
//                x.x.XPrice,
//                x.x.XAmountDb,
//                x.x.XAmount,
//                x.x.XAmountPaid,
//                x.x.XTotaltype,
//                x.x.XQuantity,
//                x.x.XStampdown,
//                x.x1.XStampfi,
//                x.x1.XStamplt,
//            })
//            .Select(g => new Crud_Sqlite.Models.Fuels0
//            {
//                Price = g.Average(x => x.x.XPricedb ?? 0),
//                AmountDB = g.Sum(x => x.x.XAmountDb ?? 0),
//                Amount = g.Sum(x => x.x.XAmountPaid ?? 0),
//                Closing = g.Max(x => x.x.XClosetotal ?? 0),
//                Liters = g.Max(x => x.x.XClosetotal ?? 0) - g.Min(x => x.x.XOpentotal ?? 0),
//                hasXOpentotalZero = g.Any(x => g.Key.XOpentotal == 0),
//                Cust = g.Key.XOpentotal == 0 ? 0 : (g.Key.XOpentotal ?? 0),
//                XAmountPaid = g.Key.XAmountPaid ?? 0,
//                XQuantity = g.Key.XQuantity ?? 0,
//                XTotaltype = g.Key.XTotaltype ?? 0,
//                XStampfi = g.Key.XStampfi,
//                XStamplt = g.Key.XStamplt,
//                ItemCode = g.Key.XItemcode
//            }).OrderBy(x => x.XTank).ThenBy(x => x.XPump);

//            var result = from i in query1
//                         join s in query2 on i.INV_DATE equals s.INV_DATE into joined
//                         from sub in joined.DefaultIfEmpty()
//                         select i;

//            var result2 = result.Select((x, index) => new Crud_Sqlite.Models.xFuelsWithPO
//            {
//                INV_DATE = x.INV_DATE,
//                XAmountDb = x.XAmountDb,
//                XAmount = x.XAmount,
//                XPump = x.XPump,
//                Opening = x.Opening,
//                Closing = x.Closing,
//                XTank = x.XTank,
//                Volume = x.Volume,
//                Liters = x.Liters,
//                Start = result.Min(r => r.Start),
//                End = result.Max(r => r.End),
//                XCorpcode = x.XCorpcode,
//                Transcount = result.Count(),
//                XSitecode = x.XSitecode,
//                XNozzle = x.XNozzle,
//                XYear = x.XYear,
//                XMonth = x.XMonth,
//                XDay = x.XDay,
//                XTransaction = x.XTransaction,
//                Calibration = x.Calibration,
//                nozdown = x.nozdown,
//                InTime = x.InTime,
//                OutTime = x.OutTime,
//                XOid = x.XOid,
//                XOname = x.XOname,
//                Shift = x.Shift,
//                plateno = x.plateno,
//                pono = x.pono,
//                Cust = x.Cust,
//                Particulars = x.Particulars,
//                Price = x.Price,
//            }).ToList();

//            resultsList = result2.OrderBy(r => r.XPump)
//           .ThenBy(r => r.Opening)
//           .ToList();
//            return resultsList;
//        }

//        [HttpGet]
//        public async Task<IActionResult> Fuels()
//        {
//            //filename
//            string fileName = "fuels_Year " + DateTime.Today.Year + ".csv";

//            //collection filepath declaration
//            string folderPath = @"C:\Collection";
//            string filePath = Path.Combine(folderPath, fileName);

//            //read collection file
//            List<string> collectionList = ReadCsvFile(filePath);

//            //get the records from journal via query
//            List<xFuelsWithPO> resultsList = Query();

//            //get properties from model
//            var properties = typeof(xFuelsWithPO).GetProperties();

//            //put the names gathered from model to string
//            string headerRow = string.Join(",", properties.Select(p => p.Name));
//            StringBuilder csvContent = new StringBuilder();

//            //adds the names as first rows
//            csvContent.AppendLine(headerRow);

//            //collects items from queried list
//            foreach (var item in resultsList)
//            {
//                var itemss = item.GetType().GetProperties();
//                var line = string.Join(",", itemss.Select(p => p.GetValue(item)?.ToString() ?? ""));
//                csvContent.AppendLine(line);
//            }

//            //saves the list 
//            System.IO.File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
//            TempData["msg"] = "<script>alert('Fuels Collection Updated');</script>";
//            return RedirectToAction("Index", "Home");
//        }

//        private List<string> ReadCsvFile(string filePath)
//        {
//            List<string> data = new List<string>();

//            try
//            {
//                string[] lines = System.IO.File.ReadAllLines(filePath);
//                foreach (string line in lines)
//                {
//                    data.Add(line);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error reading CSV file: {ex.Message}");
//            }

//            return data;
//        }

//        public List<xFuelsWithPO> updateCollection(List<xFuelsWithPO> collection, List<xFuelsWithPO> newRecords)
//        {
//            return collection;
//        }

//        public static int ExtractHours(string input)
//        {
//            try
//            {
//                string number = input.Substring(8, 2);
//                int hours = int.Parse(number);
//                return hours;
//            }
//            catch (InvalidOperationException)
//            {
//                int zero = 0;
//                return zero;
//            }
//        }
//        public static int ExtractMinutes(string input)
//        {
//            try
//            {
//                string number = input.Substring(10, 2);
//                int minutes = int.Parse(number);
//                return minutes;
//            }
//            catch (InvalidOperationException)
//            {
//                int minutes = 0;
//                return minutes;
//            }
//        }
//    }
//}


//using Crud_Sqlite.Models;
//using Microsoft.AspNetCore.Mvc;
//using System.Text;

//[HttpGet]
//public async Task<IActionResult> UpdateCsv(int sitecode, Dictionary<string, List<object>> dict, string type)
//{
//    //filename
//    string fileName = sitecode + "-" + type + "-" + DateTime.Today.Year + ".csv";

//    //collection filepath declaration
//    string folderPath = @"C:\Collection";
//    string filePath = Path.Combine(folderPath, fileName);

//    //read collection file
//    List<string> collectionList = ReadCsvFile(filePath);

//    //get the records from journal via query
//    List<xFuelsWithPO> resultsList = Query();

//    //get properties from model
//    var properties = typeof(xFuelsWithPO).GetProperties();

//    //put the names gathered from model to string
//    string headerRow = string.Join(",", properties.Select(p => p.Name));
//    StringBuilder csvContent = new StringBuilder();

//    //saves the list 
//    System.IO.File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
//    return RedirectToAction("Index", "Home");
//}



//public IActionResult SampleAppending()
//{
//    //collection pathing
//    string destPath = @"C:\Collections";
//    string collectionFile = Path.Combine(destPath, "Collected.csv");

//    //collects items from queried list
//    StringBuilder csvContent = new StringBuilder();
//    System.IO.File.WriteAllText(collectionFile, csvContent.ToString(), Encoding.UTF8);
//    return RedirectToAction("Index", "Home");
//}


//[HttpGet]
//public async Task<IActionResult> Fuels()
//{

//    //collection filename
//    string collectionName = "fuels_Year " + DateTime.Today.Year + ".csv";

//    //collection file directory
//    string collectionFolder = @"C:\Collection";
//    string collectionPath = Path.Combine(collectionFolder, collectionName);

//    string[] files = Directory.GetFiles(collectionFolder);

//    foreach (string filePath in files)
//    {
//        // Extract the file name without extension
//        string fileName = Path.GetFileNameWithoutExtension(filePath);

//        // Check if the CSV file exists
//        string csvFilePath = Path.Combine(collectionFolder, collectionName + ".csv");
//        if (System.IO.File.Exists(csvFilePath))
//        {

//            // Create the CSV file if it doesn't exist
//            using (System.IO.File.Create(csvFilePath))
//            {
//                Console.WriteLine($"CSV file '{fileName}.csv' created.");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"CSV file '{fileName}.csv' already exists.");
//        }
//    }

//    //read collection file
//    List<string> collectionList = ReadCsvFile(collectionPath);

//    //get the records from journal via query
//    List<xFuelsWithPO> resultsList = Query();

//    //get properties from model
//    var properties = typeof(xFuelsWithPO).GetProperties();

//    //put the names gathered from model to string
//    string headerRow = string.Join(",", properties.Select(p => p.Name));
//    StringBuilder csvContent = new StringBuilder();

//    //adds the names as first rows
//    csvContent.AppendLine(headerRow);

//    //collects items from queried list
//    foreach (var item in resultsList)
//    {
//        var itemss = item.GetType().GetProperties();
//        var line = string.Join(",", itemss.Select(p => p.GetValue(item)?.ToString() ?? ""));
//        csvContent.AppendLine(line);
//    }

//    //saves the list 
//    System.IO.File.WriteAllText(collectionPath, csvContent.ToString(), Encoding.UTF8);
//    TempData["msg"] = "<script>alert('Fuels Collection Updated');</script>";
//    return RedirectToAction("Index", "Home");
//}


//public static int ExtractHours(string input)
//{
//    try
//    {
//        string number = input.Substring(8, 2);
//        int hours = int.Parse(number);
//        return hours;
//    }
//    catch (InvalidOperationException)
//    {
//        int zero = 0;
//        return zero;
//    }
//}
//public static int ExtractMinutes(string input)
//{
//    try
//    {
//        string number = input.Substring(10, 2);
//        int minutes = int.Parse(number);
//        return minutes;
//    }
//    catch (InvalidOperationException)
//    {
//        int minutes = 0;
//        return minutes;
//    }
//}

//public List<xFuelsWithPO> Query()
//{
//    var resultsList = new List<xFuelsWithPO>();
//    var query1 = (from x in _dbcontext.XItems
//    join x1 in _dbcontext.XTickets on x.XTid equals x1.Id
//                  join x2 in _dbcontext.XFunctions on x.XTid equals x2.XTid
//                  where x.XApiflag == "0" &&
//                  x2.XFtype == "H" &&
//                  x2.XFindex == 12 &&
//                  x.XTank != 0 &&
//                  x.XPricedb != 0 &&
//                  x1.XYear == 2024 &&
//                  x1.XMonth == 3 &&
//                  x1.XDay == 25
//                  //((x1.XYear == DateTime.Today.Year - 1 && x1.XMonth == 12 && x1.XDay >= 1) ||  // Items from December 1st of last year
//                  // (x1.XYear == DateTime.Today.Year && x1.XMonth == DateTime.Today.Month && x1.XDay <= DateTime.Today.Day - 1) // Items from this year up to today
//                  select new { x, x1, x2 })
//.AsEnumerable()
//.GroupBy(x => new
//{
//    x.x1.XYear,
//    x.x1.XMonth,
//    x.x1.XDay,
//    x.x.XTank,
//    x.x.XItemcode,
//    x.x.XPump,
//    x.x.XNozzle,
//    x.x.XPricedb,
//    x.x.XStamp,
//    x.x1.XOid,
//    x.x1.XCorpcode,
//    x.x.XOpentotal,
//    x.x.XClosetotal,
//    x.x1.XSitecode,
//    x.x1.XTransaction,
//    x.x.XPrice,
//    x.x.XAmountDb,
//    x.x.XAmount,
//    x.x.XAmountPaid,
//    x.x.XTotaltype,
//    x.x.XQuantity,
//    x.x.XDescription,
//    x.x.XStampdown,
//    x.x1.XStampfi,
//    x.x1.XStamplt,
//    x.x1.XOname,
//    x.x1.XBatch,
//    x.x1.XTable,
//    x.x1.XTent,
//})
//.Select(g => new Crud_Sqlite.Models.Fuels0
//{
//    preInTime = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Max(),
//    preOutTime = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Min(),
//    INV_DATE = new DateTime(g.Key.XYear ?? 1, g.Key.XMonth ?? 1, g.Key.XDay ?? 1).ToString("yyyy-MM-dd"),
//    Start = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Max(), // Get the maximum time among all the records
//    End = g.Select(x => new TimeOnly(ExtractHours(x.x.XStamp), ExtractMinutes(x.x.XStamp), 0)).Min(),
//    XStamp = g.Key.XStamp,
//    XYear = g.Key.XYear ?? 0,
//    XMonth = g.Key.XMonth ?? 0,
//    XDay = g.Key.XDay ?? 0,
//    XTank = g.Key.XTank ?? 0,
//    ItemCode = g.Key.XItemcode,
//    XPump = g.Key.XPump ?? 0,
//    XNozzle = g.Key.XNozzle ?? 0,
//    XPricedb = g.Key.XPricedb ?? 0,
//    XOid = g.Key.XOid,
//    XCorpcode = g.Key.XCorpcode ?? 0,
//    XOpentotal = g.Key.XOpentotal ?? 0,
//    XClosetotal = g.Key.XClosetotal ?? 0,
//    XSitecode = g.Key.XSitecode ?? 0,
//    XTransaction = g.Key.XTransaction ?? 0,
//    XPrice = g.Key.XPrice ?? 0,
//    XAmountDb = g.Key.XAmountDb ?? 0,
//    XAmount = g.Key.XAmount ?? 0,
//    Closing = g.Max(x => x.x.XClosetotal ?? 0),
//    nozdown = g.Key.XStampdown,
//    InTime = g.Select(x => new TimeOnly(ExtractHours(x.x1.XStampfi), ExtractMinutes(x.x1.XStampfi), 0)).Max(), // Get the maximum time among all the records
//    OutTime = g.Select(x => new TimeOnly(ExtractHours(x.x1.XStamplt), ExtractMinutes(x.x1.XStamplt), 0)).Min(), // Get the maximum time among all the records
//    Liters = g.Max(x => x.x.XClosetotal ?? 0) - g.Min(x => x.x.XOpentotal ?? 0),
//    XOname = g.Key.XOname,
//    Shift = g.Key.XBatch ?? 0,
//    plateno = g.Key.XTable,
//    pono = g.Key.XTent,
//    Cust = g.Key.XOpentotal == 0 ? 0 : (g.Key.XOpentotal ?? 0),
//    Price = g.Average(x => x.x.XPricedb ?? 0),
//    Particulars = g.Key.XDescription,
//    Calibration = g.Sum(x =>
//    {
//        if (g.Key.XAmountPaid == 0.0 && g.Key.XTotaltype == 5.0)
//        { return g.Key.XQuantity ?? 0.0; }
//        else { return 0.0; }
//    }),
//    Volume = g.Sum(x =>
//    {
//        if (g.Key.XAmountPaid > 0.0 && g.Key.XTotaltype < 100.0 && g.Key.XTotaltype != 5)
//        { return g.Key.XQuantity ?? 0.0; }
//        else { return 0.0; }
//    }),
//    Opening = g.Min(x =>
//    {
//        if (g.Key.XOpentotal == 0)
//        { return 0; }
//        else { return g.Key.XOpentotal ?? 0; };
//    })
//})
//.OrderBy(x => x.XPump)
//.ThenBy(x => x.Opening);
//    var query2 = (from x in _dbcontext.XItems
//                  join x1 in _dbcontext.XTickets on x.XTid equals x1.Id
//                  join x2 in _dbcontext.XFunctions on x.XTid equals x2.Id
//                  join x3 in _dbcontext.XVips on x.XTid equals x3.Id into x3Group
//                  from x3Item in x3Group.DefaultIfEmpty()
//                  where x.XApiflag == "0" &&
//                  x2.XFtype == "H" &&
//                  x2.XFindex == 12 &&
//                  x.XTank != 0 &&
//                  x.XPricedb != 0 &&
//                  x1.XYear == 2024 &&
//                  x1.XMonth == 3 &&
//                  x1.XDay == 25
//                  //((x1.XYear == DateTime.Today.Year - 1 && x1.XMonth == 12 && x1.XDay >= 1) ||  // Items from December 1st of last year
//                  // (x1.XYear == DateTime.Today.Year && x1.XMonth == DateTime.Today.Month && x1.XDay <= DateTime.Today.Day-1) // Items from this year up to today
//                  select new { x, x1, x2 })
//    .AsEnumerable()
//    .GroupBy(x => new
//    {
//        x.x.XItemcode,
//        x.x.XOpentotal,
//        x.x.XClosetotal,
//        x.x.XPrice,
//        x.x.XAmountDb,
//        x.x.XAmount,
//        x.x.XAmountPaid,
//        x.x.XTotaltype,
//        x.x.XQuantity,
//        x.x.XStampdown,
//        x.x1.XStampfi,
//        x.x1.XStamplt,
//    })
//    .Select(g => new Crud_Sqlite.Models.Fuels0
//    {
//        Price = g.Average(x => x.x.XPricedb ?? 0),
//        AmountDB = g.Sum(x => x.x.XAmountDb ?? 0),
//        Amount = g.Sum(x => x.x.XAmountPaid ?? 0),
//        Closing = g.Max(x => x.x.XClosetotal ?? 0),
//        Liters = g.Max(x => x.x.XClosetotal ?? 0) - g.Min(x => x.x.XOpentotal ?? 0),
//        hasXOpentotalZero = g.Any(x => g.Key.XOpentotal == 0),
//        Cust = g.Key.XOpentotal == 0 ? 0 : (g.Key.XOpentotal ?? 0),
//        XAmountPaid = g.Key.XAmountPaid ?? 0,
//        XQuantity = g.Key.XQuantity ?? 0,
//        XTotaltype = g.Key.XTotaltype ?? 0,
//        XStampfi = g.Key.XStampfi,
//        XStamplt = g.Key.XStamplt,
//        ItemCode = g.Key.XItemcode
//    }).OrderBy(x => x.XTank).ThenBy(x => x.XPump);

//    var result = from i in query1
//                 join s in query2 on i.INV_DATE equals s.INV_DATE into joined
//                 from sub in joined.DefaultIfEmpty()
//                 select i;

//    var result2 = result.Select((x, index) => new Crud_Sqlite.Models.xFuelsWithPO
//    {
//        INV_DATE = x.INV_DATE,
//        XAmountDb = x.XAmountDb,
//        XAmount = x.XAmount,
//        XPump = x.XPump,
//        Opening = x.Opening,
//        Closing = x.Closing,
//        XTank = x.XTank,
//        Volume = x.Volume,
//        Liters = x.Liters,
//        Start = result.Min(r => r.Start),
//        End = result.Max(r => r.End),
//        XCorpcode = x.XCorpcode,
//        Transcount = result.Count(),
//        XSitecode = x.XSitecode,
//        XNozzle = x.XNozzle,
//        XYear = x.XYear,
//        XMonth = x.XMonth,
//        XDay = x.XDay,
//        XTransaction = x.XTransaction,
//        Calibration = x.Calibration,
//        nozdown = x.nozdown,
//        InTime = x.InTime,
//        OutTime = x.OutTime,
//        XOid = x.XOid,
//        XOname = x.XOname,
//        Shift = x.Shift,
//        plateno = x.plateno,
//        pono = x.pono,
//        Cust = x.Cust,
//        Particulars = x.Particulars,
//        Price = x.Price,
//    }).ToList();

//    resultsList = result2.OrderBy(r => r.XPump)
//   .ThenBy(r => r.Opening)
//   .ToList();
//    return resultsList;
//}


// Takes csvDir, returns List<string>
//private List<string> ReadCsvFile(string filePath)
//{
//    List<string> data = new List<string>();
//    try
//    {
//        string[] lines = System.IO.File.ReadAllLines(filePath);
//        foreach (string line in lines)
//        {
//            data.Add(line);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error reading CSV file: {ex.Message}");
//    }
//    return data;
//}