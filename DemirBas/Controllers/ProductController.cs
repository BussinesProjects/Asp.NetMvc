using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemirBas.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductList()
        {
            return View();
        }
        public ActionResult ProductAdd()
        {
            return View();
        }
        public ActionResult ProductUpdate()
        {
            return View();
        }
    }
}