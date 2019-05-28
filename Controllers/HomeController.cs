using CascadingDropdownlistSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropdownlistSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = DataManager.GetCities();

            return View(model);
        }

        [HttpPost]
        public ActionResult GetDistricts(int cityId)
        {
            var model = DataManager.GetDistrict(cityId);

            return Json(model);
        }
    }
}