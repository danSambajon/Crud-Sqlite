using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud_Sqlite.Data;
using Crud_Sqlite.Models;

namespace Crud_Sqlite.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public EmployeesController(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        // Index Action
        /*public async Task<IActionResult> Index()
        {
            var employee = await _dbcontext.XOfflines
                                         .Where(x => x.XPumpNo == 2)
                                         .ToListAsync();
            return View(employee);
        }*/

        public async Task<IActionResult> Index()
        {
            // Fetch XOffline and XTicket data and declare Combine list
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


        //Details Action
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

                var employee = await _dbcontext.XOfflines
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (employee == null)
                {
                    return NotFound();
                }

                return View(employee);
                
            }
    }
}
