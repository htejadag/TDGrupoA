using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA.Ms.Producto.Dominio.Entidades
{
    public class Producto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }


        public int IdProducto { get; set; }


        public string Nombre { get; set; }


        public decimal Precio { get; set; }


        public int Cantidad { get; set; }
    }
}
