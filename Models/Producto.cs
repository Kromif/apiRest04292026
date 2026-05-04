using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiRest04292026.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
    }
}