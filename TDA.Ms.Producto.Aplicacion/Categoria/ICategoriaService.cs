using dominio = TDA.Ms.Producto.Dominio.Entidades;

namespace TDA.Ms.Producto.Aplicacion.Categoria
{
    public interface ICategoriaService
    {
        List<dominio.Categoria> ListarTodos();
        dominio.Categoria BuscarPorId(int idCategoria);
        bool Registrar(dominio.Categoria categoria);
        bool Modificar(dominio.Categoria categoria);
        void Eliminar(int idCategoria);
    }
}
