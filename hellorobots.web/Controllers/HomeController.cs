using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hellorobots.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(bool wellThatDidntWork = false)
        {
            ViewBag.WellThatDidntWork = wellThatDidntWork;

            return View();
        }

        public ActionResult ExecuteCommand(string command)
        {
            switch (command)
            {
                case "open-the-pod-bay-doors":
                    return 
                        RedirectToAction("OpenThePodBayDoors");
                default:
                    return 
                        RedirectToAction(
                            "Index",
                            new
                            {
                                WellThatDidntWork = true
                            });
            }
        }

        public ActionResult OpenThePodBayDoors()
        {
            return View();
        }
    }
}