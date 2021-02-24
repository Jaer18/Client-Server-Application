using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Mapa
    {
        public static string Serializar(List<string> pLista)
        {
            if (pLista.Count == 0)
            {
                return null;
            }

            bool esPrimero = true;
            var salida = new StringBuilder();

            foreach (var linea in pLista)
            {
                if (esPrimero)
                {
                    salida.Append(linea);
                    esPrimero = false;
                }
                else
                {
                    salida.Append(string.Format(", {0}", linea));
                }
            }// foreach

            return salida.ToString();
        }// Serializar

        public static List<string> Deserializar(string pEntrada)
        {
            var lista = new List<string>();
            if (string.IsNullOrEmpty(pEntrada))
            {
                return lista;
            }

            try
            {
                foreach (string linea in pEntrada.Split(','))
                {
                    lista.Add(linea);
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return lista;
        }// Deserializar
    }
}
