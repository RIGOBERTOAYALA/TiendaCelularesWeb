using System.Web;
using System.Web.Mvc;

namespace CelularesWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //habilitar el filtro de sesion
           // filters.Add(new Filters.Verificar_Session());
        }
    }
}
