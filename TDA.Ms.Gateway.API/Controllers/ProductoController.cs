using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TDA.Ms.Gateway.Aplicacion.Pedidos.Request;
using TDA.Ms.Gateway.Aplicacion.ProductosClient;
using static TDA.Ms.Gateway.Api.Routes.ApiRoutes;
using Productos = TDA.Ms.Gateway.Aplicacion.ProductosClient;
using Clientes = TDA.Ms.Gateway.Aplicacion.ClientesClient;

namespace TDA.Ms.Gateway.Api.Controllers
{
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly Productos.IClient _productosClient;
        private readonly Clientes.IClient _clientesClient;

        public ProductoController(IClient productosClient, Clientes.IClient clientesClient)
        {
            _productosClient = productosClient;
            _clientesClient = clientesClient;
        }



        //[HttpGet(RouteProducto.GetAll)]
        //public ICollection<Producto> ListarProductos()
        //{
        //    var listaProductos = _productosClient.ApiV1ProductoAllAsync().Result;
        //    return listaProductos;            
        //}

        [HttpGet(RoutePedido.RegistrarPedido)]
        public void RegistrarPedido(RegistrarPedidoRequest request)
        {

            // Escoger al cliente
            var cliente = _clientesClient.ApiV1ClienteAsync(request.idCliente); 

            // Seleccionar producto
            var producto = _productosClient.ApiV1ProductoAsync(request.idProducto);

            // Llamar al método crear pedido

            // Llamar al método crear detalle pedido

            // Actualizar Stock
            _productosClient.ApiV1ProductoActualizarStockAsync(request.producto);


        }
    }
}
