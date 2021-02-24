using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class Cajero
    {
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string primerAp { get; set; }
        public string segundoAp { get; set; }
        public int cajaAsignada { get; set; }
        public bool activo { get; set; }
    }
}
