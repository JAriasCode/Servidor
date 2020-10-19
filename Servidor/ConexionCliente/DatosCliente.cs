using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class DatosCliente
    {

        public string Accion { get; set; }
        public string Datos { get; set; }

        public DatosCliente()
        {

        }

        public DatosCliente(string accion, string datos)
        {
            Accion = accion;
            Datos = datos;
        }

        public DatosCliente(string datos)
        {
            int sepIndex = datos.IndexOf(":", StringComparison.Ordinal);
            Accion = datos.Substring(0, sepIndex);
            Datos = datos.Substring(Accion.Length + 1);
        }

        public string SerializarDatos()
        {
            return string.Format("{0}:{1}", Accion, Datos);
        }

        public static implicit operator string(DatosCliente datos)
        {
            return datos.SerializarDatos();
        }


        //Acciones a realizar con la lista de datos

        public static string SerializarLista(List<string> lista)
        {
            if (lista.Count == 0)
            {
                return null;
            }

            bool PrimeroLista = true;
            var InsertarEnLista = new StringBuilder();

            foreach (var dato in lista)
            {
                if (PrimeroLista)
                {
                    InsertarEnLista.Append(dato);
                    PrimeroLista = false;
                }
                else
                {
                    InsertarEnLista.Append(string.Format(",{0}", dato));
                }
            }
            return InsertarEnLista.ToString();
        }

        public static List<string> DeserializarLista(string DatosRecibidos)
        {
            string str = DatosRecibidos;
            var lista = new List<string>();

            if (string.IsNullOrEmpty(str))
            {
                return lista;
            }

            try
            {
                foreach (string dato in DatosRecibidos.Split(','))
                {
                    lista.Add(dato);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return lista;
        }


    }

}
