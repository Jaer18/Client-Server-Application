using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class Venta
    {
        public string cajeroUsuario { get; set; }
        public DateTime fecha { get; set; }
        public int codigoProducto { get; set; }
        public decimal precioProducto { get; set; }
        public int cantidad { get; set; }
        public decimal montoTotal { get; set; }
        public int codigo { get; set; }
    }
}
