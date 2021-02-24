using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FormCliente : Form
    {
        public static ConexionTcp conexionTcp = new ConexionTcp();
        public static string IPADDRESS = "127.0.0.1";
        public const int PORT = 16830;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = false;
            enableTab(tabPageRegVenta, false);
        }// FormCliente_Load

        private void MensajeRecibido(string datos)
        {
            var paquete = new Paquete(datos);
            string comando = paquete.comando;
            if (comando == "resultadoCajero")
            {
                string contenido = paquete.contenido;

                Invoke(new Action(() => MessageBox.Show(contenido)));
            }
            if (comando == "resultadoVenta")
            {
                string contenido = paquete.contenido;

                Invoke(new Action(() => MessageBox.Show(contenido)));
            }
            if (comando == "resultadoIncSes")
            {
                string contenido = paquete.contenido;

                Invoke(new Action(() => MessageBox.Show(contenido)));

                if(contenido == "Sesión Iniciada")
                {
                    if (tabPageRegVenta.InvokeRequired)
                    {
                        tabPageRegVenta.Invoke(new MethodInvoker(delegate { enableTab(tabPageRegVenta, true); }));
                    }
                }
            }
        }// MensajeRecibido


        private void FormCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// FormCliente_FormClosing

        private void btnRegistrarCajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexionTcp.TcpClient.Connected)
                {
                    if (String.IsNullOrWhiteSpace(txtCajeroUsuario.Text) || String.IsNullOrWhiteSpace(txtCajeroNombre.Text)
                        || String.IsNullOrWhiteSpace(txtCajeroPrimerAp.Text) || String.IsNullOrWhiteSpace(txtCajeroSegundoAp.Text))
                    {
                        MessageBox.Show("Debe llenar todos los espacios");
                    }
                    else
                    {
                        var msgPack = new Paquete("insertarCajero", string.Format("{0},{1},{2},{3}",
                        txtCajeroUsuario.Text, txtCajeroNombre.Text, txtCajeroPrimerAp.Text,
                        txtCajeroSegundoAp.Text));
                        conexionTcp.EnviarPaquete(msgPack);
                    }
                }
                else
                {
                    MessageBox.Show("No se logro realizar la conexión", "Error de Conexión");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtCajeroUsuario.Clear();
            txtCajeroNombre.Clear();
            txtCajeroPrimerAp.Clear();
            txtCajeroSegundoAp.Clear();
            txtCajeroCaja.Clear();
        }// btnRegistrarCajero_Click

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexionTcp.TcpClient.Connected)
                {
                    if (String.IsNullOrWhiteSpace(txtVentaUsuario.Text) || String.IsNullOrWhiteSpace(txtVentaCodProd.Text)
                        || String.IsNullOrWhiteSpace(txtVentaCantProd.Text))
                    {
                        MessageBox.Show("Debe llenar todos los espacios");
                    }
                    else
                    {
                        var msgPack = new Paquete("insertarVenta", string.Format("{0},{1},{2},{3}",
                        txtVentaUsuario.Text, dtpVentaFecha.Value.ToString(), txtVentaCodProd.Text,
                        txtVentaCantProd.Text));
                        conexionTcp.EnviarPaquete(msgPack);
                    }
                }
                else
                {
                    MessageBox.Show("No se logro realizar la conexión", "Error de Conexión");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtVentaUsuario.Clear();
            txtVentaCodProd.Clear();
            txtVentaCantProd.Clear();
        }// btnRegistrarVenta_Click

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionTcp.OnDataRecieved += MensajeRecibido;

                if (!conexionTcp.Connectar(IPADDRESS, PORT))
                {
                    MessageBox.Show("Error conectando con el servidor!");
                    return;
                }

                if (conexionTcp.TcpClient.Connected)
                {
                    var msgPack = new Paquete("usuarioConectado", "Un usuario se ha conectado");
                    conexionTcp.EnviarPaquete(msgPack);
                }
                else
                {
                    MessageBox.Show("No se logro realizar la conexión", "Error de Conexión");
                }

                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }// btnConectar_Click

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexionTcp.TcpClient.Connected)
                {
                    var msgPack = new Paquete("usuarioDesconectado", "Un usuario se ha desconectado");
                    conexionTcp.EnviarPaquete(msgPack);
                }
                else
                {
                    MessageBox.Show("No se logro realizar la conexión", "Error de Conexión");
                }

                conexionTcp.TcpClient.Close();

                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }// btnDesconectar_Click

        public static void enableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }// enableTab

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexionTcp.TcpClient.Connected)
                {
                    if (String.IsNullOrWhiteSpace(txtInicioSesion.Text))
                    {
                        MessageBox.Show("Debe indicar un código de usuario");
                    }
                    else
                    {
                        var msgPack = new Paquete("inicioSesion", txtInicioSesion.Text);
                        conexionTcp.EnviarPaquete(msgPack);
                    }
                }
                else
                {
                    MessageBox.Show("No se logro realizar la conexión", "Error de Conexión");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtInicioSesion.Clear();
        }// btnInicioSesion_Click

    }// class FormClient

}// namespace Cliente
