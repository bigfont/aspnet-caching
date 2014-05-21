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
        #region Default Views
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

        #region Six OutputCacheLocations
        [OutputCache(Location = OutputCacheLocation.Any, Duration = 0)]
        public ViewResult One()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Client, Duration = 0)]
        public ViewResult Two()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Downstream, Duration = 0)]
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
        #endregion

        #region OutputCacheLocation.Client
        [OutputCache(Location = OutputCacheLocation.Client, Duration = 3600, NoStore = true)]
        public ViewResult ClientNoStoreTrue()
        {
            return View();
        }
        [OutputCache(Location = OutputCacheLocation.Client, Duration = 3600, NoStore = false)]
        public ViewResult ClientNoStoreFalse()
        {
            return View();
        }
        #endregion

        #region Cache Profiles

        [OutputCache(CacheProfile="VeryTransparent")]
        public ViewResult VeryTransparent()
        {
            return View();
        }

        #endregion
    }
}