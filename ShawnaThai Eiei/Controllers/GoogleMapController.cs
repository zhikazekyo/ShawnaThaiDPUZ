using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;
using System.Data.Entity.Validation;

namespace ShawnaThai_Eiei.Controllers
{
    public class GoogleMapController : Controller
    {
        ShawnaThaiEntities db = new ShawnaThaiEntities();
        [HttpGet]
        // GET: GoogleMap
        public ActionResult GoogleMap()
        {
            string query = "SELECT * FROM Cooperative ";

            var data = db.Database.SqlQuery<Cooperative>(query).OrderByDescending(c => c.Coop_Name).ToList();

            return View(data);
        }
    }
}