using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacts.Controllers{
    public class HomeController : Controller{
        public ActionResult Index(){
            return View();
        }

        public ActionResult ListDB(){
            ViewBag.Message = "I'm still trying to learn to return data from MySQL Database Server";

            return View();
        }

        public ActionResult List(){
            ViewBag.Message = "It's Something";

            return View();
        }
    }
}