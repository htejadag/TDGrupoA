using dominio = TDA.Ms.Producto.Dominio.Entidades;

namespace TDA.Ms.Producto.Aplicacion.Producto
{
    public interface IProductoService
    {
        // Read
        List<dominio.Producto> ListarProductos();
        dominio.Producto BuscarPorId(int idProducto);

        // Write
        bool Registrar(dominio.Producto producto);
        bool Modificar(dominio.Producto producto);
        void Eliminar(int idProducto);
        bool ActualizarStock(int idProducto, int cantidad);
    }
}
