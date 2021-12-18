using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zabuka.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult BlogDetail()
        {
            return View();
        }
        public ActionResult Blogs()
        {
            return View();
        }
    }
}