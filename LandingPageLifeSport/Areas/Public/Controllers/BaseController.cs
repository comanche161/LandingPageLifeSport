using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LandingPageLifeSport.Areas.Public.Controllers
{
    public class BaseController : Controller
    {
        // GET: Public/Base
        public ActionResult Index()
        {
            return View();
        }
    }
}