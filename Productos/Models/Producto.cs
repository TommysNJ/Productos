using System;
using System.ComponentModel.DataAnnotations;

namespace Productos.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public String Nombre { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}

