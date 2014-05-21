using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        #region Defaults
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #endregion

        [OutputCache(Location = OutputCacheLocation.Any)]
        public ViewResult One()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Client)]
        public ViewResult Two()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Downstream)]
        public ViewResult Three()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.None)]
        public ViewResult Four()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Server)]
        public ViewResult Five()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.ServerAndClient)]
        public ViewResult Six()
        {
            return View();
        }
    }
}