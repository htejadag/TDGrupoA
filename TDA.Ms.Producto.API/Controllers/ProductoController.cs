using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace TDA.Ms.Producto.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        public static List<Producto> listaProducto = new List<Producto>
            {
                new Producto()
                {
                    IdProducto = 1,
                    Nombre = "Arroz",
                    Precio = 10.0m,
                    Cantidad = 5
                },
                new Producto()
                {
                    IdProducto = 2,
                    Nombre = "Leche",
                    Precio = 8.0m,
                    Cantidad = 11
                }
            };

        [HttpGet(Name = "ListarProductos")]
        public IEnumerable<Producto> ListarProductos()
        {
            return listaProducto;
        }

        [HttpPost(Name = "CrearProducto")]
        public ActionResult<Producto> CrearProducto(Producto producto)
        {
            producto.IdProducto = listaProducto.Count() + 1;
            listaProducto.Add(producto);
            return CreatedAtAction("CrearProducto", producto);
        }

    }
}
