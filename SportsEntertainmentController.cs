using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zabuka.Controllers
{
    public class SportsEntertainmentController : Controller
    {
        //
        // GET: /SportsEntertainment/
        public ActionResult SportsEntertainment()
        {
            return View();
        }
        public ActionResult ContestDetails()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }
	}
}