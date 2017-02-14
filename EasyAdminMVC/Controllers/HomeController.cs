using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyAdminMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Session["email"] == null)
                return RedirectToAction("Index", "Account");
            
            return View();
        }
        public ActionResult Search(string q)
        {
            var db = new ComplainCenterEntities();
            var users = db.Users.Where(u => u.Name.ToLower().Contains(q.ToLower())
                || u.Email.ToLower().Contains(q.ToLower())
                );
            return PartialView((object)users);
        }
    }
}
