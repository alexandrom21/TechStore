using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Productos
    {
        [Display(Name = "Nombre del producto")]
        [Required]
        public String? nombreProducto {get;set;}

        [Display(Name = "Descripcion del producto")]
        [Required]
        public String? descripcion {get;set;}

        [Display(Name = "Precio del producto")]
        [Required]
        public double precio {get;set;}

        public double precioIGV {get;set;}
    }
}