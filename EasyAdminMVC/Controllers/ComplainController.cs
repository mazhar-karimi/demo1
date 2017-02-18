using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyAdminMVC.Controllers
{
    public class ComplainController : Controller
    {

        //private int pageSize = 10;
        public ActionResult Index(int p = 0, int pageSize = 10)
        {
            using (var db = new ComplainCenterEntities())
            {
                var complains = db.Complains.OrderBy(x => x.Id).Skip(p * pageSize).Take(pageSize).ToList();

                return View(complains);
            }

        }
        public ActionResult Create()
        {
            return View();
        }
    }
}
