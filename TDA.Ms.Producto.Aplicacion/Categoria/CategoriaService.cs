using MongoDB.Driver;
using Release.MongoDB.Repository;
using System.Linq.Expressions;
using dominio = TDA.Ms.Producto.Dominio.Entidades;

namespace TDA.Ms.Producto.Aplicacion.Categoria
{

    public class CategoriaService : ICategoriaService
    {
        private readonly ICollectionContext<dominio.Categoria> _categoria;
        private readonly IBaseRepository<dominio.Categoria> _categoriaR;

        public CategoriaService(ICollectionContext<dominio.Categoria> categoria,
                                IBaseRepository<dominio.Categoria> categoriaR)
        {
            _categoria = categoria;
            _categoriaR = categoriaR;
        }

        public List<dominio.Categoria> ListarTodos()
        {
            Expression<Func<dominio.Categoria, bool>> filter = s => s.esEliminado == false;
            var items = (_categoria.Context().FindAsync(filter, null).Result).ToList();
            return items;
        }

        public bool Registrar(dominio.Categoria categoria)
        {
            categoria.esEliminado = false;
            categoria.fechaCreacion = DateTime.Now;
            categoria.esActivo = true;

            // _categoria.Context().InsertOne(categoria);                       

            var p = _categoriaR.InsertOne(categoria);

            return true;
        }

        public dominio.Categoria BuscarPorId(int idCategoria)
        {
            Expression<Func<dominio.Categoria, bool>> filter = s => s.esEliminado == false && s.idCategoria == idCategoria;
            var item = (_categoria.Context().FindAsync(filter, null).Result).FirstOrDefault();
            return item;
        }

        public void Eliminar(int idCategoria)
        {
            Expression<Func<dominio.Categoria, bool>> filter = s => s.esEliminado == false && s.idCategoria == idCategoria;
            var item = (_categoria.Context().FindOneAndDelete(filter, null));

        }        

        public bool Modificar(dominio.Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
