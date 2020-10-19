using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class Cliente
    {

        public ConexionCliente conexion { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Cliente()
        {

        }

        public Cliente(ConexionCliente conexion, string usuario, string password)
        {
            this.conexion = conexion;
            this.usuario = usuario;
            this.password = password;
        }
    }
}
