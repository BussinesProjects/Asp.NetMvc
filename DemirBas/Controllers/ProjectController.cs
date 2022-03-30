using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemirBas.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Acount
        public ActionResult ProjectList()
        {
            return View();
        }
        public ActionResult ProjectAdd()
        {
            return View();
        }
        //public ActionResult ProjectUpdate()
        //{
        //    return View();
        //}
        public ActionResult Products()
        {
            return View();
        }

    }
}