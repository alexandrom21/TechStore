using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;

namespace TechStore.Controllers
{
     public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Productos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("nombreProducto,descripcion,precio")] Productos productos )
        {
            if(ModelState.IsValid)
            {
                double precioIGV = productos.precio * 1.18;
                return View("Producto");
            }
            
            return View("Producto");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}