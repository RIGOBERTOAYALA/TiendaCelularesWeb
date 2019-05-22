using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CelularesWeb.Models;
using CelularesWeb.Models.DTOs;


namespace CelularesWeb.Controllers
{
    public class FabricantesController : Controller
    {
        // GET: Fabricantes
        public ActionResult Index()
        {
            List<Fabricantes_dto> IstFabricante = null;
            using (TIENDASEntities db = new TIENDASEntities())
            {
                IstFabricante = (from f in db.FABRICANTES
                                 orderby f.NOM_FABRICANTE
                                 select new Fabricantes_dto
                                 {
                                     IdFabricante = f.ID_FABRICANTE,
                                     NomFabricante = f.NOM_FABRICANTE,
                                     PaisFabricante = f.NOM_FABRICANTE
                                 }
                                 ).ToList();
            }
                return View(IstFabricante);
        }
        public ActionResult Add()

        {
            Fabricantes_dto fabricantes_Dto = new Fabricantes_dto();
            List<DOMINIO> lstPaises = null;

            using (TIENDASEntities db = new TIENDASEntities())
            {
                lstPaises = (from d in db.DOMINIOS
                             where d.TIPO_DOMINIO == "paises"
                             orderby d.VLR_DOMINIO
                             select  new DOMINIO
                             {
                                 ID_DOMINIO = d.TIPO_DOMINIO,
                                 VLR_DOMINIO = d.VLR_DOMINIO
                             }).ToList();
                fabricantes_Dto.lstPaises = lstPaises;
                   
            }
                return View();
        }
    }
}