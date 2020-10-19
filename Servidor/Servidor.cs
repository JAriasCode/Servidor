using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Servidor : Form
    {
        public delegate void ClientCarrier(ConexionCliente conexioCliente);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(ConexionCliente conexionCliente, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener ListenerCliente;
        private Thread ThreadCliente;
        private List<ConexionCliente> ClienteConectado = new List<ConexionCliente>();

        public Servidor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Acciones
        //Botón salir
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Servidor_Load(object sender, EventArgs e)
        {
            OnDataRecieved += MensajeRecibido;
            OnClientConnected += ConexionRecibida;
            OnClientDisconnected += ConexionCerrada;

            ClienteListener("192.168.0.9", 25565);
        }

        private void Servidor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEnviarNotif_Click(object sender, EventArgs e)
        {
            try
            {
                var mensaje = new DatosCliente("Nueva Notificacion", txtNotas.Text);
                ConexionCliente con = ListaClientes.getConexionCliente(cboClientes.Text.ToString());
                con.EnviarPaquete(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente no se encuentra disponible, verifique que se encuentre logueado en el sistema.", "Se ha presentado un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region Procedimientos
        //Método de escucha a los clientes
        private void ClienteListener(string ipAddress, int port)
        {
            try
            {
                ListenerCliente = new TcpListener(IPAddress.Parse(ipAddress), port);
                ListenerCliente.Start();
                ThreadCliente = new Thread(AceptarUsuarios);
                ThreadCliente.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        //Método que recibe mensajes de los clientes
        private void MensajeRecibido(ConexionCliente conexionCliente, string datos)
        {
            var datosCliente = new DatosCliente(datos);
            string comando = datosCliente.Accion;
            string contenido = datosCliente.Datos;
            List<string> valores = DatosCliente.DeserializarLista(contenido);

            Cliente cliente = new Cliente(conexionCliente, valores[0], valores[1]);

            //Mensaje que recibe la consulta de si debe permitir iniciar sesión al usuario
            if (comando.Equals("login"))
            {
                DialogResult boton = MessageBox.Show("El cliente " + valores[0] + " esta solicitando conectarse", "Solicitud de inicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var mensaje = new DatosCliente("Ingresar", "OK");
                if (boton == DialogResult.No)
                    mensaje = new DatosCliente("No Ingresar", "NO");

                conexionCliente.EnviarPaquete(mensaje);
                Invoke(new Action(() => txtEventos.Text += "Inicio de sesión del usuario: " + valores[0] + "\r\n"));
                foreach(Cliente cli in ListaClientes.listaClientes)
                {
                    if (cli.usuario.Equals(valores[0]))
                        cli.conexion = conexionCliente;
                }
                ListaClientes.listaClientes.Add(cliente);

            }
        }

        //Método que acepta al cliente
        private void AceptarUsuarios()
        {
            do
            {
                try
                {
                    var conexion = ListenerCliente.AcceptTcpClient();
                    var srvClient = new ConexionCliente(conexion)
                    {
                        ReadThread = new Thread(LeerDatos)
                    };
                    srvClient.ReadThread.Start(srvClient);

                    if (OnClientConnected != null)
                        OnClientConnected(srvClient);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            } while (true);
        }

        //Método que lee los datos del cliente
        private void LeerDatos(object client)
        {
            var cli = client as ConexionCliente;
            var charBuffer = new List<int>();

            do
            {
                try
                {
                    if (cli == null)
                        break;
                    if (cli.StreamReader.EndOfStream)
                        break;
                    int charCode = cli.StreamReader.Read();
                    if (charCode == -1)
                        break;
                    if (charCode != 0)
                    {
                        charBuffer.Add(charCode);
                        continue;
                    }
                    if (OnDataRecieved != null)
                    {
                        var chars = new char[charBuffer.Count];

                        for (int i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }

                        var message = new string(chars);


                        OnDataRecieved(cli, message);
                    }
                    charBuffer.Clear();
                }
                catch (IOException error)
                {
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());

                    break;
                }
            } while (true);

            if (OnClientDisconnected != null)
                OnClientDisconnected(cli);
        }

        //Método que recibe la conexión
        private void ConexionRecibida(ConexionCliente conexionCliente)
        {
            lock (ClienteConectado)
                if (!ClienteConectado.Contains(conexionCliente))
                    ClienteConectado.Add(conexionCliente);
            Invoke(new Action(() => txtTotalClientes.Text = string.Format(ClienteConectado.Count + ".")));
        }

        //Método que cierra la conexión
        private void ConexionCerrada(ConexionCliente conexionCliente)
        {
            lock (ClienteConectado)
                if (ClienteConectado.Contains(conexionCliente))
                {
                    int cliIndex = ClienteConectado.IndexOf(conexionCliente);
                    ClienteConectado.RemoveAt(cliIndex);
                }
            Invoke(new Action(() => txtTotalClientes.Text = string.Format(ClienteConectado.Count + ".")));
        }

        #endregion

    }


}
