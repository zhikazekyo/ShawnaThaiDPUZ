using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;

namespace ShawnaThai_Eiei.Controllers
{
    public class HistoryTableController : Controller
    {
        ShawnaThaiEntities db = new ShawnaThaiEntities();
        // GET: HistoryTable
        public ActionResult HistoryTable()
        {

            var id2 = Session["id"];
            int id = Convert.ToInt32(id2);

            var AID = Session["AD_ID"];
            //string del= "Delete FROM Product_Rice where ProD_IDSell = ' " + id2+"'";
            //var lob = db.Database.SqlQuery<Product_Rice>(del);
            string query = "SELECT * FROM History_Sell where AD_ID = ' " + AID + "'";
            var data = db.Database.SqlQuery<History_Sell>(query).OrderByDescending(c => c.ProD_IDSell).ToList();

            //string query2 = "SELECT * FROM Product_Rice where ProD_IDSell = ' " + id + "'";
            //var data2 = db.Database.SqlQuery<Product_Rice>(query).ToList();






            //return View();


            return View(Tuple.Create(data/*,data2*/));
        }






    }
}