using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crud_Sqlite.Models;
using Crud_Sqlite.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Query_ojt.Controllers
{
    public class JamesController : Controller
    {
        private readonly JournalContext _context;
        public JamesController(JournalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var xOfflineList = await _context.XOfflines.ToListAsync();
            var xTicketList = await _context.XTickets.ToListAsync();
            var xItemList = await _context.XItems.ToListAsync();
            var xCardList = await _context.XCards.ToListAsync();
            var xFunctionList = await _context.XFunctions.ToListAsync();
            var xVipList = await _context.XVips.ToListAsync();

            // Your existing code to perform the join operation in memory
            var combineList = xOfflineList
                .Select(xOffline => new CombineVM
                {
                    xOfflines = xOffline,
                    xTickets = xTicketList.FirstOrDefault(x => x.Id == xOffline.Id),
                    xItems = xItemList.FirstOrDefault(x => x.Id == xOffline.Id),
                    xCards = xCardList.FirstOrDefault(x => x.Id == xOffline.Id),
                    xFunctions = xFunctionList.FirstOrDefault(x => x.Id == xOffline.Id),
                    xVips = xVipList.FirstOrDefault(x => x.Id == xOffline.Id)
                })
                .ToList();

            var startEndTimes = _context.XTickets
        .Join(_context.XItems, ticket => ticket.Id, item => item.XTid, (ticket, item) => new { ticket, item })
        .GroupBy(g => new { g.ticket.XYear, g.ticket.XMonth, g.ticket.XDay, g.ticket.XOid })
        .Select(g => new
        {
            INV_DATE = new DateTime(g.Key.XYear ?? 0, g.Key.XMonth ?? 0, g.Key.XDay ?? 0),
            InTime = g.Min(x => x.item.XStamp.Substring(8, 2) + ":" + x.item.XStamp.Substring(10, 2)),
            OutTime = g.Max(x => x.item.XStamp.Substring(8, 2) + ":" + x.item.XStamp.Substring(10, 2))
        })
        .AsEnumerable()
        .Select(se => new Tuple<DateTime, TimeSpan, TimeSpan>(
            se.INV_DATE,
            TimeSpan.Parse(se.InTime),
            TimeSpan.Parse(se.OutTime)
        )).ToList();

            var viewModel = new ViewMTime
            {
                timerange = startEndTimes,
                combineVMlist = combineList
            };

            return View(viewModel);
        }
    }
}