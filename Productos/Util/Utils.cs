using System;
using Productos.Models;

namespace Productos.Util
{
	public class Utils
	{
        public static List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Producto1",
                Descripcion = "Descripcion1",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre = "Producto2",
                Descripcion = "Descripcion2",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 3,
                Nombre = "Producto3",
                Descripcion = "Descripcion3",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 4,
                Nombre = "Producto4",
                Descripcion = "Descripcion4",
                Cantidad = 1
            },
        };

    }
}

