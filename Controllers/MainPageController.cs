using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GoGoods()
        {
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
        public IActionResult GoWarehouse()
        {
            return RedirectToRoute(new { controller = "Warehouse", action = "WareHouseIndex" });
        }
        public IActionResult GoApplications()
        {
            return RedirectToRoute(new { controller = "AppInfo", action = "Application" });
        }
        public IActionResult GoContacts()
        {
            return RedirectToRoute(new { controller = "Contacts", action = "ContactsInf" });
        }
    }
}
