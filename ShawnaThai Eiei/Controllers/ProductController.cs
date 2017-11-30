using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;

namespace ShawnaThai_Eiei.Controllers
{
    public class ProductController : Controller
    {
        ShawnaThaiEntities db = new ShawnaThaiEntities();
        // GET: Product
        public ActionResult Product(int id)
        {
            var A = db.Product_Rice.Find(id);



            return View(A);


        }
    }
}






