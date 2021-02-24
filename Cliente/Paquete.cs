using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Paquete
    {
        public string comando { get; set; }
        public string contenido { get; set; }

        public Paquete()
        {

        }

        public Paquete(string pComando, string pContenido)
        {
            comando = pComando;
            contenido = pContenido;
        }

        public Paquete(string datos)
        {
            int indiceSeparador = datos.IndexOf(":", StringComparison.Ordinal);
            comando = datos.Substring(0, indiceSeparador);
            contenido = datos.Substring(comando.Length + 1);
        }

        public string Serializar()
        {
            return string.Format("{0}:{1}", comando, contenido);
        }

        public static implicit operator string(Paquete pPaquete)
        {
            return pPaquete.Serializar();
        }
    }
}
