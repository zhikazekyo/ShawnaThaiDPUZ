using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;

namespace ShawnaThai_Eiei.Controllers
{
    public class BuyController : Controller
    {

        ShawnaThaiEntities db = new ShawnaThaiEntities();
        // GET: Buy

        public ActionResult Buy(int id)
        {


            string query = "SELECT Coop_Name FROM Farmer ";
            var data = db.Database.SqlQuery<Farmer>(query).OrderByDescending(c => c.Coop_Name).ToList();

           
            return View(data);
        }
    }
}