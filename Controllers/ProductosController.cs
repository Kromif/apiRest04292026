using apiRest04292026.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace apiRest04292026.Controllers
{
    //public class ProductosController : Controller
    public class ProductosController : ApiController
    {
        // GET: Productos
		private static List<Producto> productos = new List<Producto>
		{
			new Producto { Id = 1, Nombre = "Taco al pastor", Precio = 25.00m, Disponible = true },
			new Producto { Id = 2, Nombre = "Quesadilla de queso", Precio = 20.00m, Disponible = true },
			new Producto { Id = 3, Nombre = "Torta de milanesa", Precio = 45.00m, Disponible = false }
		};

        //public IEnumerable<Producto> Get() => productos;
        public IHttpActionResult Get() => Ok(productos);

        public IHttpActionResult Get(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            //return producto == null ? NotFound() : Ok(producto);
            if (producto == null)
                return NotFound();
            return Ok(producto);
        }
    }
}