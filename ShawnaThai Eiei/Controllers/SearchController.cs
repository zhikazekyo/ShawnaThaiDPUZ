using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;
using System.Data.Entity.Validation;

namespace ShawnaThai_Eiei.Controllers
{
    public class SearchController : Controller
    {
       
        // GET: Search
        public ActionResult SearchProduct()
        {
            string query = "SELECT * FROM RiceType ";
            var test = db.Database.SqlQuery<RiceType>(query).ToList();
            return View(test);
        }

        ShawnaThaiEntities db = new ShawnaThaiEntities();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchProduct(string WeightMax, string WeightMin, string PriceMin, string PriceMax,string MoistureMin, string MoistureMax, string Rtype)
        {

            string query = "SELECT * FROM RiceType ";
            var test = db.Database.SqlQuery<RiceType>(query).ToList();



            //string query2 = "SELECT * FROM Product_Rice";
            //var test2 = db.Database.SqlQuery<Product_Rice>(query2).ToList();

           
                int WeightMin2 = Convert.ToInt32(WeightMin);
                int WeightMax2 = Convert.ToInt32(WeightMax);


                int PriceMin2 = Convert.ToInt32(PriceMin);

                int PriceMax2 = Convert.ToInt32(PriceMax);

                int MoistureMin2 = Convert.ToInt32(MoistureMin);

                int MoistureMax2 = Convert.ToInt32(MoistureMax);

            if (WeightMin2 > WeightMax2 || PriceMin2 > PriceMax2 || MoistureMin2 > MoistureMax2)

            {
                ViewBag.Message = "ใส่ใหม่";
                return View(test);
            }
            else
            {

                string query4 = "SELECT* FROM Product_Rice Where(ProD_Weight Between " + (WeightMin2 - 1) + " AND " + (WeightMax2 + 1) + ") AND (ProD_Price Between " + (PriceMin2 - 1) + " AND " + (PriceMax2 + 1) + ") AND (ProD_Moisture Between " + (MoistureMin2 - 1) + " AND " + (MoistureMax2 + 1) + " ) AND (RType_Name IN ('" + Rtype + "'))";
                //var testz = db.Database.SqlQuery<Product_Rice>(query4).ToList();
                return RedirectToAction("Sellingz", "Search", new { query4 = query4 });

            }
        }
        public ActionResult Sellingz(string query4)
        {
            var dataz = db.Database.SqlQuery<Product_Rice>(query4).ToList();
            return View(dataz);
        }
    }
}