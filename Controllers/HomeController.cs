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

namespace Crud_Sqlite.Controllers
    {
    public class HomeController : Controller
        {
        private readonly ApplicationDbContext _dbcontext;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _dbcontext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> XOffline()
        {
            var xOfflineList = await _dbcontext.XOfflines.ToListAsync();
            var xTicketList = await _dbcontext.XTickets.ToListAsync();
            var combineList = new List<Combine>();
            foreach (var xOffline in xOfflineList)
            {
                var xTicket = xTicketList.FirstOrDefault(x => x.Id == xOffline.Id);
                combineList.Add(new Combine { xOffline = xOffline, xTicket = xTicket });
            }
            return View(combineList);
        }
    }
}