using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TDA.Ms.Gateway.Aplicacion.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using MediatR;

namespace TDA.Ms.Gateway.Aplicacion
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            // Client Settings
            var msSettings = new ClientSettings();
            configuration.Bind(nameof(ClientSettings), msSettings);

            #region Cliente MsProductos

            services.AddHttpClient("MsProductos", client =>
            {
                client.BaseAddress = new Uri(msSettings.ProductosUrl);
            });

            #endregion

            #region Cliente MsClientes

            services.AddHttpClient("MsClientes", client =>
            {
                client.BaseAddress = new Uri(msSettings.ClientesUrl);
            });

            #endregion

            #region Clientes

            services.AddTransient<ProductosClient.IClient, ProductosClient.Client>();
            services.AddTransient<ClientesClient.IClient, ClientesClient.Client>();

            #endregion

            return services;
        }

    }
}
