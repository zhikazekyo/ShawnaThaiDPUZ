using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShawnaThai_Eiei.Models;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.IO;

namespace ShawnaThai_Eiei.Controllers
{
    public class RegisterCooperativeController : Controller
    {
        // GET: RegisterCooperative
        ShawnaThaiEntities db = new ShawnaThaiEntities();
        public ActionResult RegisterCooperative()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterCooperative(string Coop_Name, string Coop_Latitude, string Coop_Longtitude, string Coop_Tel, string Coop_A_No, string Coop_A_Sup, string Coop_A_District, string AD_ID, string Coop_A_Province)
        {

            Cooperative cooperative = new Cooperative();
            cooperative.Coop_Name = Coop_Name;
            cooperative.Coop_Latitude = Coop_Latitude;
            cooperative.Coop_Longitude = Coop_Longtitude;
            cooperative.Coop_Tel = Coop_Tel;
            cooperative.Coop_A_No = Coop_A_No;
            cooperative.Coop_A_Sup = Coop_A_Sup;
            cooperative.Coop_A_District = Coop_A_District;
            cooperative.Coop_A_Province = Coop_A_Province;







            if (ModelState.IsValid)
            {
                if (Coop_Name != null)
                {
                    var check_coop = db.Cooperatives.Where(a => a.Coop_Name.Equals(Coop_Name)).FirstOrDefault<Cooperative>();
                    if (check_coop != null)
                    {
                        ViewBag.Message = " Try again .";
                        return View();
                    }
                    else
                    {
                        try
                        {
                            db.Cooperatives.Add(cooperative);

                            db.SaveChanges();
                            return RedirectToAction("Index", "Index");
                        }
                        catch (DbEntityValidationException ex)
                        {
                            var errorMessages = ex.EntityValidationErrors.SelectMany(e => e.ValidationErrors).Select(e => e.ErrorMessage);
                            var fullErrorMessage = string.Join("; ", errorMessages);
                            var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);
                            throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                        }
                    }

                }

            }

            return RedirectToAction("Login", "Login");
        }
    }
}