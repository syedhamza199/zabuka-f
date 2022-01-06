using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zabuka.Controllers
{
    public class HumanRightsController : Controller
    {
        //
        // GET: /HumanRights/
        public ActionResult HumanRights()
        {
            return View();
        }
        public ActionResult DonateNow()
        {
            return View();
        }
	}
}