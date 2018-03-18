using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FHN_IPL_Fantasy.Controllers
{
    public class IPLSeasonController : Controller
    {
        // GET: IPLSeason
        public ActionResult Index()
        {
            return View();
        }
    }
}