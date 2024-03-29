﻿namespace TDA.Ms.Producto.API.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class RouteProducto
        {
            // Read
            public const string GetAll = Base + "/producto/all";
            public const string GetById = Base + "/producto/{id}";

            // Write
            public const string Create = Base + "/producto/create";
            public const string Update = Base + "/producto/update";
            public const string Delete = Base + "/producto/delete";
            public const string ActualizarStock = Base + "/producto/actualizarStock";
        }

        public static class RouteCategoria
        {
            // Read
            public const string GetAll = Base + "/categoria/all";
            public const string GetById = Base + "/categoria/{id}";

            // Write
            public const string Create = Base + "/categoria/create";
            public const string Update = Base + "/categoria/update";
            public const string Delete = Base + "/categoria/delete";
        }
    }
}
