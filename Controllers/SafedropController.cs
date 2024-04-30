using Microsoft.AspNetCore.Mvc;

namespace Crud_Sqlite.Controllers
{
    public class SafedropController : Controller
    {
        public IActionResult presaferop()
        {
            return View();
        }

        public IActionResult presafedrop()
        {
            return View();
        }
    }
}