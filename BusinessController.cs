using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zabuka.Controllers
{
    public class BusinessController : Controller
    {
        //
        // GET: /Business/
        public ActionResult Business()
        {
            return View();
        }
        public ActionResult RegisterBusiness()
        {
            return View();
        }
	}
}