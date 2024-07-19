using eskiyeniDeneme.Data;
using eskiyeniDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eskiyeniDeneme.Controllers
{
    public class CalcController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Calc
        public ActionResult Index()
        {
            var calculations = db.Calculations.ToList();
            return View(calculations);
        }

        [HttpPost]
       
        public ActionResult SaveCalculation(calc model)
        {
            if (ModelState.IsValid)
            {
                db.Calculations.Add(model);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false, error = "Model state is not valid" });
        }
    }
}