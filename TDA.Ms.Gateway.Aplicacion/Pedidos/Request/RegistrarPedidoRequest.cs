using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDA.Ms.Gateway.Aplicacion.ProductosClient;

namespace TDA.Ms.Gateway.Aplicacion.Pedidos.Request
{
    public class RegistrarPedidoRequest
    {
        public int idCliente { get; set; }

        public int idProducto { get; set; }

        public Producto producto { get; set; }
    }
}
