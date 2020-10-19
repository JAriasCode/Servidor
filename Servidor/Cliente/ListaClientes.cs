using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class ListaClientes
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        public ListaClientes()
        {
            
        }

        public static ConexionCliente getConexionCliente(string usuario)
        {
            try
            {
                foreach (Cliente cliente in listaClientes)
                {
                    if (cliente.usuario.Equals(usuario))
                        return cliente.conexion;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
