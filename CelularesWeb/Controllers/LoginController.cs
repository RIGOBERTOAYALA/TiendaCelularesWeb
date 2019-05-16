using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CelularesWeb.Models;

namespace CelularesWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Enter(string user, string pwd)

        {
            try
            {
                using (TIENDASEntities db = new TIENDASEntities())
                {
                    decimal idUser;
                    decimal.TryParse(user, out idUser);
                    var usuarios = from p in db.PERSONAs
                                   where p.ID_PERSONA == idUser && p.contraseñá == pwd && p.TIPO_PERSONA == "EMP"
                                   select p;
                    if (usuarios.Count() > 0)
                    {
                        PERSONA opersonas = usuarios.First();
                        Session["user"] = opersonas;
                        return Content("1");
                    }
                    else
                    {
                        return Content("usuario o contraseña incorrectos");

                    }
                }
            }
            catch (Exception e)
            {
                return Content("Error:" + e.Message);
            }
        }
    }
}