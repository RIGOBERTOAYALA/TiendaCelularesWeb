using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CelularesWeb.Models.DTOs
{
    public class Fabricantes_dto
    {
        public decimal IdFabricante{get; set;}
        [Required] 
        [Display(Name ="Nombre fabricante")]
        public String NomFabricante { get; set; }
        [Required]
        [Display(Name = "Pais fabricante")]
        public String PaisFabricante { get; set; }

        public List<DOMINIO> lstPaises { get; set; }


    }
}