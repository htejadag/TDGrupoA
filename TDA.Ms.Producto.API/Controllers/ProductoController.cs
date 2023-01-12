using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TDA.Ms.Producto.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController
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


    }
}
