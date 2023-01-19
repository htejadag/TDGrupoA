﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using MongoDB.Driver;

namespace TDA.Ms.Producto.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        //public static List<Producto> listaProducto = new List<Producto>
        //    {
        //        new Producto()
        //        {
        //            IdProducto = 1,
        //            Nombre = "Arroz",
        //            Precio = 10.0m,
        //            Cantidad = 5
        //        },
        //        new Producto()
        //        {
        //            IdProducto = 2,
        //            Nombre = "Leche",
        //            Precio = 8.0m,
        //            Cantidad = 11
        //        }
        //    };

        [HttpGet(Name = "ListarProductos")]
        public IEnumerable<Producto> ListarProductos()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TDA_productos");
            var collection = database.GetCollection<Producto>("producto");

            var listaProducto = collection.Find(x=>true).ToList();

            return listaProducto;
        }

        [HttpPost(Name = "CrearProducto")]
        public ActionResult<Producto> CrearProducto(Producto producto)
        {
            //producto.IdProducto = listaProducto.Count() + 1;
            //listaProducto.Add(producto);
            return CreatedAtAction("CrearProducto", producto);
        }

        [HttpPut(Name = "ModificarProducto")]
        public ActionResult<Producto> ModificarProducto(Producto producto)
        {
            //var productoModificado = listaProducto.Single(x => x.IdProducto == producto.IdProducto);
            //productoModificado.Nombre = producto.Nombre;
            //productoModificado.Precio = producto.Precio;
            //productoModificado.Cantidad = producto.Cantidad;
            return CreatedAtAction("ModificarProducto", producto);
        }

        [HttpDelete(Name = "EliminarProducto")]
        public ActionResult<Producto> EliminarProducto(int idProducto)
        {
            //listaProducto.RemoveAt(idProducto - 1);
            return CreatedAtAction("EliminarProducto", idProducto);
        }

    }
}
