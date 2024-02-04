using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        loginEntities db = new loginEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user log)
        {
           var user = db.users. Where(x=>x.Username == log.Username && x.Password == log.Password ).Count();
           if (user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}