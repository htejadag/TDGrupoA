using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using MongoDB.Driver;
using TDA.Ms.Producto.API.Routes;
using MongoDB.Bson;

namespace TDA.Ms.Producto.API.Controllers
{
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(ApiRoutes.RouteProducto.GetAll)]
        public IEnumerable<Producto> ListarProductos()
        {
            #region Conexion a la base de datos
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TDA_productos");
            var collection = database.GetCollection<Producto>("producto");
            #endregion

            var listaProducto = collection.Find(x => true).ToList();

            return listaProducto;
        }

        [HttpGet(ApiRoutes.RouteProducto.GetById)]
        public Producto BuscarProducto(string id)
        {
            #region Conexion a la base de datos
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TDA_productos");
            var collection = database.GetCollection<Producto>("producto");
            #endregion

            var objProducto = collection.Find(x => x._id == id).FirstOrDefault();

            return objProducto;
        }

        [HttpPost(ApiRoutes.RouteProducto.Create)]
        public ActionResult<Producto> CrearProducto(Producto producto)
        {
            #region Conexion a la base de datos
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TDA_productos");
            var collection = database.GetCollection<Producto>("producto");
            #endregion

            producto._id = ObjectId.GenerateNewId().ToString();

            collection.InsertOne(producto);

            return CreatedAtAction("CrearProducto", producto);
        }

        [HttpPut(ApiRoutes.RouteProducto.Update)]
        public ActionResult<Producto> ModificarProducto(Producto producto)
        {
            #region Conexion a la base de datos
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TDA_productos");
            var collection = database.GetCollection<Producto>("producto");
            #endregion

            collection.ReplaceOne(x => x._id == producto._id, producto);

            return CreatedAtAction("ModificarProducto", producto);
        }

        [HttpDelete(ApiRoutes.RouteProducto.Delete)]
        public ActionResult<Producto> EliminarProducto(string id)
        {
            #region Conexion a la base de datos
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TDA_productos");
            var collection = database.GetCollection<Producto>("producto");
            #endregion

            collection.DeleteOne(x => x._id == id);

            //listaProducto.RemoveAt(idProducto - 1);
            return Ok();
        }

    }
}
