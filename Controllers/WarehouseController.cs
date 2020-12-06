using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Data.EntFR;
using WebApp.Model;

namespace WebApp.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly ENWhouse eNWarehouses;

        public WarehouseController(ENWhouse eNWhouse)
        {
            this.eNWarehouses = eNWhouse;
        }
        public IActionResult WareHouseIndex()
        {
            return View(eNWarehouses.GetAllItem());
        }
        public IActionResult WhouseEdit(Guid id)
        {
            mWarehouse model = id == default ? new mWarehouse() : eNWarehouses.GetENWhouseById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult WhouseEdit(mWarehouse model)
        {
            if (ModelState.IsValid)
            {
                eNWarehouses.SaveWhouse(model);
                return RedirectToRoute(new { controller = "Warehouse", action = "WareHouseIndex" });
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult WhouseDelete(Guid id)
        {
            eNWarehouses.DeleteWhouse(new mWarehouse { wID = id });
            return RedirectToRoute(new { controller = "Warehouse", action = "WareHouseIndex" });
        }
    }
}
