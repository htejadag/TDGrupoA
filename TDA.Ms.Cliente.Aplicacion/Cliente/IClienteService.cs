using dominio = TDA.Ms.Cliente.Dominio.Entidades;

namespace TDA.Ms.Cliente.Aplicacion.Cliente
{
    public interface IClienteService
    {
        List<dominio.Cliente> ListarClientes();
        bool Registracliente(dominio.Cliente cliente);
        dominio.Cliente Cliente(int idCliente);
        void Eliminar(int idCliente);
    }
}
