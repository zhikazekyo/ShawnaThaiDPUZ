using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;

namespace ShawnaThai_Eiei.Controllers
{
    public class SellingController : Controller
    {

        ShawnaThaiEntities db = new ShawnaThaiEntities();
        // GET: Sellingz


        public ActionResult Selling()
        {
            string query1 = "SELECT * FROM Product_Rice ";

            var data1 = db.Database.SqlQuery<Product_Rice>(query1).OrderByDescending(c => c.ProD_IDSell).ToList();

            var id2 = Session["id"];
            int id = Convert.ToInt32(id2);
            string query = "SELECT * FROM Product_Rice where ProD_IDSell = '" + id + "'";

            var data = db.Database.SqlQuery<Product_Rice>(query).OrderByDescending(c => c.ProD_IDSell).ToList();

            return View(data1);
        }
    }
}