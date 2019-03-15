using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class DataPassController : Controller
    {
        // GET: DataPass
        public ActionResult Index()
        {
            ViewBag.Message = "HI kaustubh";
            return View();
        }

    }
}