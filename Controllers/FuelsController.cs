using System;
using System.IO.MemoryMappedFiles;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud_Sqlite.Data;
using Crud_Sqlite.Models;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using Crud_Sqlite.Migrations;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Crud_Sqlite.Controllers
{
    public class FuelsController : Controller
    {
        private readonly JournalContext _context;
        private readonly ApplicationDbContext _dbcontext;
        private readonly ILogger<FuelsController> _logger;
        private readonly IMemoryCache _memoryCache;
        public FuelsController(ILogger<FuelsController> logger, ApplicationDbContext context, IMemoryCache memoryCache)
        {
            _logger = logger;
            _dbcontext = context;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            GenerateUpdate(1);
            GenerateUpdate(2);
            GenerateUpdate(3);
            TempData["msg"] = "<script>Swal.fire({\r\n            icon: \"success\",\r\n            title: \"Generation Success!\",\r\n            showConfirmButton: true,\r\n            // timer: 1500\r\n        });</script>";
            return RedirectToAction("Generated", "Fuels");
        }

        public bool IsThereJournal()
        {
            string SQLPath = "D:\\RealSoft\\RealPOS\\realhq\\journal.sqlite";
            if (System.IO.File.Exists(SQLPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        public IActionResult Generate()
        {
            bool isThereJournal = IsThereJournal();
            if (isThereJournal)
            {
                string sqliteFilePath = "D:\\RealSoft\\RealPOS\\realhq\\journal.sqlite";
                object siteCode;
                string siteCodeQuery = $"SELECT xSITECODE FROM xTickets LIMIT 1;";
                using (var connection = new SqliteConnection($"Data Source={sqliteFilePath};"))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(siteCodeQuery, connection))
                    {
                        siteCode = command.ExecuteScalar();
                    }
                }
                RowsCount count = new RowsCount();
                count.fuels = 0;
                count.Lubes = 0;
                count.safedrops = 0;
                string fuelsPath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-fuels-2024.csv";
                string LubesPath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-Lubes-2024.csv";
                string safedropsPath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-safedrops-2024.csv";
                if (System.IO.File.Exists(fuelsPath))
                {
                    count.fuels = CountRows(1);
                }
                if (System.IO.File.Exists(LubesPath))
                {
                    count.Lubes = CountRows(2);
                }
                if (System.IO.File.Exists(safedropsPath))
                {
                    count.safedrops = CountRows(3);
                }
                return View("Generate", count);
            }

            else
            {
                TempData["msg"] = "<script>noJournal();</script>";
                return View("NoDatabase");
            }
        }

        [HttpGet]
        public IActionResult Generated()
        {
            string sqliteFilePath = "D:\\RealSoft\\RealPOS\\realhq\\journal.sqlite";
            object siteCode;
            string siteCodeQuery = $"SELECT xSITECODE FROM xTickets LIMIT 1;";
            using (var connection = new SqliteConnection($"Data Source={sqliteFilePath};"))
            {
                connection.Open();
                using (var command = new SqliteCommand(siteCodeQuery, connection))
                {
                    siteCode = command.ExecuteScalar();
                }
            }
            RowsCount count = new RowsCount();
            count.fuels = 0;
            count.Lubes = 0;
            count.safedrops = 0;
            string fuelsPath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-fuels-2024.csv";
            string LubesPath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-Lubes-2024.csv";
            string safedropsPath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-safedrops-2024.csv";
            if (System.IO.File.Exists(fuelsPath))
            {
                count.fuels = CountRows(1);
            }
            if (System.IO.File.Exists(LubesPath))
            {
                count.Lubes = CountRows(2);
            }
            if (System.IO.File.Exists(safedropsPath))
            {
                count.safedrops = CountRows(3);
            }
            return View("Generated", count);
        }

        [HttpGet]
        public IActionResult Close()
        {
            return View("Close");
        }

        public void GenerateUpdate(int type)
        {
            object siteCode;
            string query = "";
            string destPath = "";
            string sqliteFilePath = "";
            string name = "";
            string sqlPath = "D:\\RealSoft\\RealPOS\\realhq";
            switch (type)
            {
                case 1:
                    query = @"
                            SELECT DISTINCT
                            i.*,s.*
                            FROM
                            (SELECT DISTINCT
                            Min(InTime) as Start,Max(OutTime) as End       
                            FROM(
                            SELECT DISTINCT
                            date(xYear||'-01-01','+'||(xMONTH-1)||' month','+'||(xDay-1)||' day') INV_DATE,
                            xTANK,
                            min(time(substr(x.xSTAMP,9,2)||':'||substr(x.xSTAMP,11,2))) InTime,
                            max(time(substr(x.xSTAMP,9,2)||':'||substr(x.xSTAMP,11,2))) OutTime,  
                            xOID                                   
                            FROM xItems x 
                            INNER JOIN xTickets x1 ON (x.xTid=x1.id)
                            INNER JOIN xFunctions x2 ON (x.xTid=x2.xTid)
                            WHERE  x.xAPIFLAG=0 and (x2.xFLAG & 2)= 0 and (x1.xFLAG & 2)=0 and xFTYPE='H' and xFINDEX=12 and xTANK <>0 and xPRICEDB <> 0
                             GROUP BY INV_DATE,xTANK,xITEMCODE,xPUMP,xNOZZLE,xPRICEDB) t WHERE 1=1  
                            --AND INV_DATE='2023-12-01'
                            and INV_DATE between strftime('%Y','now')||'-01-01' and strftime('%Y','now')||'-'||strftime('%m','now')||'-'||strftime('%d','now')
                             ORDER BY xTANK,xOID) i,

                            (SELECT DISTINCT
                            date(xYear||'-01-01','+'||(xMONTH-1)||' month','+'||(xDay-1)||' day') INV_DATE,
                            xCORPCODE,xSITECODE,xTANK,xPUMP,xNOZZLE,
                            xYEAR,xMONTH,xDAY,xTRANSACTION,                                          
                            avg(x.xPRICEDB) Price,    
                            sum(x.xAmountDB) AmountDB,                                                                                                      
                            sum(x.xAmountPaid) Amount,
                            0.0+sum( case when x.xAmountPaid=0 and x.xTOTALTYPE=5 then xQUANTITY else 0.0 end) Calibration,
                            0.0+sum( case when x.xAmountPaid > 0 and x.xTOTALTYPE < 100 and x.xTOTALTYPE<>5 then xQUANTITY else 0.0 end) Volume,                                                                                                                                     
                            x.xITEMCODE ItemCode,
                            x.xDESCRIPTION Particulars,
                            0.0+min(nullif(x.xOPENTOTAL,0)+0) Opening,
                            max(x.xCLOSETOTAL) Closing,
                            xSTAMPDOWN as nozdown,
                            min(time(substr(x1.xSTAMPFI,9,2)||':'||substr(x1.xSTAMPFI,11,2))) InTime,
                            max(time(substr(x1.xSTAMPLT,9,2)||':'||substr(x1.xSTAMPLT,11,2))) OutTime,                                               
                            0.0+max(x.xCLOSETOTAL)-min(nullif(x.xOPENTOTAL,0)+0) Liters,
                            xOID,xONAME,x1.xBATCH Shift, 
                            x1.xTABLE plateno,
                            x1.xTENT pono,
                            ifnull(x3.xvip_fname,'') cust,
                            count(*) TransCount                                                                                   
                            FROM xItems x 
                            INNER JOIN xTickets x1 ON (x.xTid=x1.id)
                            INNER JOIN xFunctions x2 ON (x.xTid=x2.xTid)
                            LEFT JOIN xVIP x3 ON (x.xTid=x3.xTid)
                            WHERE  x.xAPIFLAG=0 and (x2.xFLAG & 2)= 0 and (x1.xFLAG & 2)=0 and xFTYPE='H' and xFINDEX=12 and xTANK <>0 and xPRICEDB <> 0
                             GROUP BY INV_DATE,xTANK,xITEMCODE,xPUMP,xNOZZLE,xPRICEDB,xTRANSACTION,x.id) s WHERE 1=1  
                            --AND INV_DATE='2023-12-01'
                            --and xYEAR=strftime('%Y','now') and xMONTH=strftime('%m','now') and xDay=strftime('%d','now')
                            and INV_DATE between strftime('%Y','now')||'-01-01' and strftime('%Y','now')||'-'||strftime('%m','now')||'-'||strftime('%d','now')
                             ORDER BY xTANK,xOID";
                    sqliteFilePath = System.IO.Path.Combine(sqlPath, "journal.sqlite");
                    destPath = "D:\\RealSoft\\RealPOS\\realhq";
                    name = "fuels";
                    break;
                case 2:
                    query = @"
                            SELECT DISTINCT
                                s.*
                            FROM (
                                SELECT DISTINCT
                                    DATE(xYear || '-01-01', '+' || (xMONTH - 1) || ' month', '+' || (xDay - 1) || ' day') AS INV_DATE,
                                    DATE(SUBSTR(x1.xSTAMP, 1, 4) || '-' || SUBSTR(x1.xSTAMP, 5, 2) || '-' || SUBSTR(x1.xSTAMP, 7, 2)) AS BDate,
                                    xYEAR,
                                    xMONTH,
                                    xDAY,
                                    xCORPCODE,
                                    xSITECODE,
                                    TIME(SUBSTR(x1.xSTAMP, 9, 2) || ':' || SUBSTR(x1.xSTAMP, 11, 2) || ':' || SUBSTR(x1.xSTAMP, 13, 2)) AS TTime,
                                    x1.xSTAMP,
                                    x1.xOID,
                                    xONAME,
                                    xBatch AS Shift,
                                    xAMOUNT1 AS Amount
                                FROM 
                                    xFunctions x2 
                                INNER JOIN 
                                    xTickets x1 ON x2.xTid = x1.id
                                WHERE 
                                    x2.xACCOUNTCODE IN ('SD', 'LC', 'CASH')
                            ) s
                            INNER JOIN 
                                xml_USERINFO u ON 1=1
                            WHERE 
                                INV_DATE BETWEEN DATE(STRFTIME('%Y', 'now', '-1 year') || '-12-01') AND DATE('now')
                            ORDER BY 
                                INV_DATE";
                    sqliteFilePath = System.IO.Path.Combine(sqlPath, "journal.sqlite");
                    destPath = "D:\\RealSoft\\RealPOS\\realhq";
                    name = "Lubes";
                    break;
                case 3:
                    query = @"
                            SELECT DISTINCT
                            s.*
                            FROM (
                            SELECT DISTINCT
                            date(xYear||'-01-01','+'||(xMONTH-1)||' month','+'||(xDay-1)||' day') INV_DATE,
                            date(substr(x1.xSTAMP,1,4)||'-'||substr(x1.xSTAMP,5,2)||'-'||substr(x1.xSTAMP,7,2) ) BDate,    
                            xYEAR,xMONTH,xDAY,xCORPCODE,xSITECODE,
                            time(substr(x1.xSTAMP,9,2)||':'||substr(x1.xSTAMP,11,2)||':'||substr(x1.xSTAMP,13,2) ) TTime,                          
                            x1.xSTAMP,
                            x1.xOID,xONAME,xBatch as Shift,              
                            xAMOUNT1 Amount                                         
                                      
                            FROM xFunctions x2 
                            INNER JOIN xTickets x1 ON (x2.xTid=x1.id)
                            WHERE x2.xACCOUNTCODE='SD' or x2.xACCOUNTCODE='LC') s,xml_USERINFO u
                            WHERE 
                             INV_DATE between strftime('%Y','now')||'-01-01' and strftime('%Y','now')||'-'||strftime('%m','now')||'-'||strftime('%d','now')
                             ORDER BY INV_DATE 
                            ";
                    sqliteFilePath = System.IO.Path.Combine(sqlPath, "journal.sqlite");
                    destPath = "D:\\RealSoft\\RealPOS\\realhq";
                    name = "safedrops";
                    break;
            }
            string siteCodeQuery = $"SELECT xSITECODE FROM xTickets LIMIT 1;";
            using (var connection = new SqliteConnection($"Data Source={sqliteFilePath};"))
            {
                connection.Open();
                using (var command = new SqliteCommand(siteCodeQuery, connection))
                {
                    siteCode = command.ExecuteScalar();
                }
            }
            string fileName = siteCode + "-" + name + "-" + DateTime.Today.Year + ".csv";
            var resultDict = new Dictionary<string, List<object>>();
            var stopwatch = Stopwatch.StartNew();
            using (var sqliteConnection = new SqliteConnection($"Data Source={sqliteFilePath};"))
            {
                sqliteConnection.Open();
                using (var command = new SqliteCommand(query, sqliteConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var columnNames = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            columnNames.Add(reader.GetName(i));
                        }
                        foreach (var columnName in columnNames)
                        {
                            resultDict[columnName] = new List<object>();
                        }
                        while (reader.Read())
                        {
                            foreach (var columnName in columnNames)
                            {
                                resultDict[columnName].Add(reader[columnName]);
                            }
                        }
                    }
                }
            }

            List<object> flattenedList = resultDict.Values.SelectMany(list => list).ToList();
            string collectionFolder = @"D:\RealSoft\RealPOS\realhq";
            string collectionPath = System.IO.Path.Combine(collectionFolder, fileName);
            using (StreamWriter sw = new StreamWriter(collectionPath))
            {
                if (resultDict.Count == 0)
                {
                    sw.WriteLine("");
                }
                else
                {
                    var columnNames = resultDict.Keys.ToList();
                    string headerRow = string.Join(",", columnNames);
                    sw.WriteLine(headerRow);
                    int maxRowCount = resultDict.Values.Max(list => list.Count);
                    for (int i = 0; i < maxRowCount; i++)
                    {
                        List<string> rowData = new List<string>();
                        foreach (var columnName in columnNames)
                        {
                            if (resultDict.ContainsKey(columnName) && resultDict[columnName].Count > i)
                            {
                                rowData.Add((resultDict[columnName][i] ?? "").ToString());
                            }
                            else
                            {
                                rowData.Add(null);
                            }
                        }
                        sw.WriteLine(string.Join(",", rowData));
                    }
                }
            }
        }

        public int CountRows(int type)
        {
            string sqliteFilePath = "D:\\RealSoft\\RealPOS\\realhq\\journal.sqlite";
            object siteCode;
            string siteCodeQuery = $"SELECT xSITECODE FROM xTickets LIMIT 1;";
            using (var connection = new SqliteConnection($"Data Source={sqliteFilePath};"))
            {
                connection.Open();
                using (var command = new SqliteCommand(siteCodeQuery, connection))
                {
                    siteCode = command.ExecuteScalar();
                }
            }
            int value = 0;
            string filePath = "";
            int rowCount = 0;
            switch (type)
            {
                case 1:
                    filePath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-fuels-2024.csv";
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            reader.ReadLine();
                            rowCount++;
                        }
                    }
                    ViewBag.FuelsCount = rowCount-1;
                    break;
                case 2:
                    filePath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-Lubes-2024.csv";
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            reader.ReadLine();
                            rowCount++;
                        }
                    }
                    ViewBag.LubesCount = rowCount-1;
                    break;
                case 3:
                    filePath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-safedrops-2024.csv";
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            reader.ReadLine();
                            rowCount++;
                        }
                    }
                    ViewBag.SafedropsCount = rowCount - 1;
                    break;
            }
            return rowCount-1;
        }

        public IActionResult DownloadFile(int fileNumber)
        {
            string filePath;
            string fileName;
            string sqliteFilePath = "D:\\RealSoft\\RealPOS\\realhq\\journal.sqlite";
            object siteCode;
            string siteCodeQuery = $"SELECT xSITECODE FROM xTickets LIMIT 1;";
            using (var connection = new SqliteConnection($"Data Source={sqliteFilePath};"))
            {
                connection.Open();
                using (var command = new SqliteCommand(siteCodeQuery, connection))
                {
                    siteCode = command.ExecuteScalar();
                }
            }
            switch (fileNumber)
            {
                case 1:
                    filePath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-fuels-2024.csv";
                    fileName = $@"{siteCode}-fuels-2024.csv";
                    break;
                case 2:
                    filePath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-Lubes-2024.csv";
                    fileName = $@"{siteCode}-Lubes-2024.csv";
                    break;
                case 3:
                    filePath = $@"D:\RealSoft\RealPOS\realhq\{siteCode}-safedrops-2024.csv";
                    fileName = $@"{siteCode}-safedrops-2024.csv";
                    break;
                default:
                    return NotFound();
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/octet-stream", fileName);
        }
    }
}