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
    public class HomeController : Controller
    {
        private readonly ENGoods eNGoods;

        public HomeController(ENGoods eNGoods)
        {
            this.eNGoods = eNGoods;
        }

        public  IActionResult Index()//Передаем все записи в индекс
        {
            return View(eNGoods.GetAllItem());
        }
        public IActionResult GoodsEdit(Guid id)
        {
            mGoods model = id == default ? new mGoods() : eNGoods.GetENGoodsById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult GoodsEdit(mGoods model)
        {
            if (ModelState.IsValid)
            {
                eNGoods.SaveGoods(model);
                return RedirectToAction("Home/Index");
            }

            return View(model);
        }
        [HttpPost] 
        public IActionResult GoodsDelete(Guid id)
        {
            eNGoods.DeleteGoods(new mGoods { GID = id });
            return RedirectToAction("Home/Index");
        }
    }
}
