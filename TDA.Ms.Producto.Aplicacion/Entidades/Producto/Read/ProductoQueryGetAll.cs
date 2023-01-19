using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDA.Ms.Producto.Infraestructura.DBRepository;
using dominio = TDA.Ms.Producto.Dominio.Entidades;

namespace TDA.Ms.Producto.Aplicacion.Entidades.Producto.Read
{
    public class ProductoQueryGetAll
    {
        internal DBRepository _repository = new DBRepository();
        private IMongoCollection<dominio.Producto> _producto;

        public ProductoQueryGetAll()
        {
            _producto = _repository.db.GetCollection<dominio.Producto>("producto");
        }

        public IEnumerable<dominio.Producto> ListarProductos()
        {
            return _producto.Find(x => true).ToList();
        }
    }
}
