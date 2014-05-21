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

        [OutputCache(Location = OutputCacheLocation.Any, Duration=0)]
        public ViewResult One()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Client, Duration=0)]
        public ViewResult Two()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Downstream, Duration=0)]
        public ViewResult Three()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.None, Duration = 0)]
        public ViewResult Four()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Server, Duration = 0)]
        public ViewResult Five()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.ServerAndClient, Duration = 0)]
        public ViewResult Six()
        {
            return View();
        }
    }
}