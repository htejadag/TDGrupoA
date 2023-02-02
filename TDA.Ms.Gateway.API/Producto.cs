using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace TDA.Ms.Producto.API
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
