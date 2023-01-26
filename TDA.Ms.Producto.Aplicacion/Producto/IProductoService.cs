using dominio = TDA.Ms.Producto.Dominio.Entidades;

namespace TDA.Ms.Producto.Aplicacion.Producto
{
    public interface IProductoService
    {
        List<dominio.Producto> ListarProductos();
        bool Registraproducto(dominio.Producto producto);
        dominio.Producto Producto(int idProducto);
        void Eliminar(int idProducto);
    }
}
