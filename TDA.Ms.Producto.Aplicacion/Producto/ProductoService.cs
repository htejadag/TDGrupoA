using MongoDB.Driver;
using Release.MongoDB.Repository;
using System.Linq.Expressions;
using dominio = TDA.Ms.Producto.Dominio.Entidades;

namespace TDA.Ms.Producto.Aplicacion.Producto
{

    public class ProductoService : IProductoService
    {
        private readonly ICollectionContext<dominio.Producto> _producto;
        private readonly IBaseRepository<dominio.Producto> _productoR;

        public ProductoService(ICollectionContext<dominio.Producto> producto, 
                                IBaseRepository<dominio.Producto> productoR)
        {
            _producto = producto;
            _productoR = productoR;
        }

        public List<dominio.Producto> ListarProductos()
        {
            Expression<Func<dominio.Producto, bool>> filter = s => s.esEliminado == false;
            var items = (_producto.Context().FindAsync(filter, null).Result).ToList();
            return items;
        }

        public bool Registrar(dominio.Producto producto)
        {
            producto.esEliminado = false;
            producto.fechaCreacion =DateTime.Now;
            producto.esActivo = true;

           // _producto.Context().InsertOne(producto);                       

            var p = _productoR.InsertOne(producto);

            return true;
        }

        public dominio.Producto BuscarPorId(int idProducto)
        {
            Expression<Func<dominio.Producto, bool>> filter = s => s.esEliminado == false && s.idProducto == idProducto;
            var item = (_producto.Context().FindAsync(filter, null).Result).FirstOrDefault();
            return item;
        }

        public void Eliminar(int idProducto)
        {
            Expression<Func<dominio.Producto, bool>> filter = s => s.esEliminado == false && s.idProducto == idProducto;
            var item = (_producto.Context().FindOneAndDelete(filter, null));
            
        }

        public bool Modificar(dominio.Producto producto)
        {
            throw new NotImplementedException();
        }

        public bool ActualizarStock(int idProducto, int cantidad)
        {
            var producto = BuscarPorId(idProducto);

            producto.cantidad += cantidad;

            _productoR.UpdateOne(producto.id, producto);

            return true;
        }
    }
}
