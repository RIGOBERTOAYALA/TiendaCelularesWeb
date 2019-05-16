using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CelularesWeb.Controllers;
using CelularesWeb.Models;


namespace CelularesWeb.Filters
{
    public class Verificar_Session :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //obtener de la sesion los datos de la persona logueada
            var opersonas = (PERSONA) HttpContext.Current.Session["user"];
            // si la sesion no existe redireccionamos al login
            if (opersonas == null)
            {
                if(filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/HOME/Index");
                }

            }
            else
            {
                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/HOME/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}