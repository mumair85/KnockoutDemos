using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KO.Web.Controllers
{
    public class WebResourcesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}