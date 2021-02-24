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
    public partial class FormServidor : Form
    {
        public delegate void ClientCarrier(ConexionTcp conexionTcp);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(ConexionTcp conexionTcp, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private List<ConexionTcp> connectedClients = new List<ConexionTcp>();

        ConexionBD conexiondb = new ConexionBD();

        public FormServidor()
        {
            InitializeComponent();
        }

        private void FormServidor_Load(object sender, EventArgs e)
        {
            OnDataRecieved += MensajeRecibido;
            OnClientConnected += ConexionRecibida;
            OnClientDisconnected += ConexionCerrada;

            EscucharClientes("127.0.0.1", 16830);
        }// FormServidor_Load

        private void MensajeRecibido(ConexionTcp conexionTcp, string datos)
        {
            var paquete = new Paquete(datos);
            string comando = paquete.comando;
            if (comando == "insertarCajero")
            {
                string contenido = paquete.contenido;
                List<string> valores = Mapa.Deserializar(contenido);
                Cajero cajero = new Cajero();
                cajero.usuario = valores[0];
                cajero.nombre = valores[1];
                cajero.primerAp = valores[2];
                cajero.segundoAp = valores[3];
                cajero.cajaAsignada = 0;
                cajero.activo = false;

                conexiondb.InsertarCajero(cajero);

                var msgPack = new Paquete("resultadoCajero", "Registro completado.");
                conexionTcp.EnviarPaquete(msgPack);

                if (txtBitacora.InvokeRequired)
                {
                    txtBitacora.Invoke(new MethodInvoker(delegate { txtBitacora.Text = txtBitacora.Text + "Nuevo cajero registrado: " + DateTime.Now.ToString() + "\r\n"; }));
                }
            }
            if (comando == "insertarVenta")
            {
                string contenido = paquete.contenido;
                List<string> valores = Mapa.Deserializar(contenido);
                string usuario = valores[0];
                DateTime fecha = Convert.ToDateTime(valores[1]);
                int codProd = Convert.ToInt32(valores[2]);
                int cantidad = Convert.ToInt32(valores[3]);
                decimal precio;
                decimal montoTotal;
                if(conexiondb.validarUsuario(usuario) != 0)
                {
                    if (conexiondb.esActivo(usuario))
                    {
                        if(conexiondb.validarCodProducto(codProd) != 0)
                        {
                            if (conexiondb.obtenerCantidad(codProd) >= cantidad)
                            {
                                precio = conexiondb.obtenerPrecio(codProd);
                                montoTotal = precio * cantidad;
                                Venta venta = new Venta();
                                venta.cajeroUsuario = usuario;
                                venta.fecha = fecha;
                                venta.codigoProducto = codProd;
                                venta.precioProducto = precio;
                                venta.cantidad = cantidad;
                                venta.montoTotal = montoTotal;
                                conexiondb.insertarVenta(venta);
                                var msgPack = new Paquete("resultadoVenta", "Registro completado.");
                                conexionTcp.EnviarPaquete(msgPack);

                                int nuevaCant = conexiondb.obtenerCantidad(codProd) - cantidad;
                                conexiondb.actualizarCantidad(codProd, nuevaCant);

                                if (txtBitacora.InvokeRequired)
                                {
                                    txtBitacora.Invoke(new MethodInvoker(delegate { txtBitacora.Text = txtBitacora.Text + "Nueva venta registrada: " + DateTime.Now.ToString() + "\r\n"; }));
                                }
                            }
                            else
                            {
                                var msgPackProdInsuficiente = new Paquete("resultadoVenta", "No hay suficiente inventario del producto para realizar la venta.");
                                conexionTcp.EnviarPaquete(msgPackProdInsuficiente);
                            }
                        }
                        else
                        {
                            var msgPackProdNoEncontrado = new Paquete("resultadoVenta", "Producto no encontrado.");
                            conexionTcp.EnviarPaquete(msgPackProdNoEncontrado);
                        }
                    }
                    else
                    {
                        var msgPackUsuarioNoAutorizd = new Paquete("resultadoVenta", "Usuario no Autorizado.");
                        conexionTcp.EnviarPaquete(msgPackUsuarioNoAutorizd);
                    }
                }
                else
                {
                    var msgPackUsuarioNoEncontrado = new Paquete("resultadoVenta", "Usuario no encontrado.");
                    conexionTcp.EnviarPaquete(msgPackUsuarioNoEncontrado);
                }
            }
            if (comando == "usuarioConectado")
            {
                string contenido = paquete.contenido;

                if (txtBitacora.InvokeRequired)
                {
                    txtBitacora.Invoke(new MethodInvoker(delegate { txtBitacora.Text = txtBitacora.Text + contenido + ": " + DateTime.Now.ToString() + "\r\n"; }));
                }
            }
            if (comando == "usuarioDesconectado")
            {
                string contenido = paquete.contenido;

                if (txtBitacora.InvokeRequired)
                {
                    txtBitacora.Invoke(new MethodInvoker(delegate { txtBitacora.Text = txtBitacora.Text + contenido + ": " + DateTime.Now.ToString() + "\r\n"; }));
                }
            }
            if (comando == "inicioSesion")
            {
                string contenido = paquete.contenido;
                bool cajeroAutorizado = conexiondb.esActivo(contenido);

                if (conexiondb.validarUsuario(contenido) != 0)
                {
                    if (cajeroAutorizado)
                    {
                        var msgPackAutorizado = new Paquete("resultadoIncSes", "Sesión Iniciada");
                        conexionTcp.EnviarPaquete(msgPackAutorizado);
                    }
                    else
                    {
                        var msgPack = new Paquete("resultadoIncSes", "Usuario no autorizado. Debe esperar a que se le autorize para registrar ventas.");
                        conexionTcp.EnviarPaquete(msgPack);
                    }
                }
                else
                {
                    var msgPack = new Paquete("resultadoIncSes", "Usuario no encontrado.");
                    conexionTcp.EnviarPaquete(msgPack);
                }
            }
        }// MensajeRecibido

        private void ConexionRecibida(ConexionTcp conexionTcp)
        {
            lock (connectedClients)
                if (!connectedClients.Contains(conexionTcp))
                    connectedClients.Add(conexionTcp);
            Invoke(new Action(() => lbCajerosConectados.Text = string.Format("Cajeros Conectados: {0}", connectedClients.Count)));
        }// ConexionRecibida

        private void ConexionCerrada(ConexionTcp conexionTcp)
        {
            lock (connectedClients)
                if (connectedClients.Contains(conexionTcp))
                {
                    int cliIndex = connectedClients.IndexOf(conexionTcp);
                    connectedClients.RemoveAt(cliIndex);
                }
            Invoke(new Action(() => lbCajerosConectados.Text = string.Format("Cajeros Conectados: {0}", connectedClients.Count)));
        }// ConexionCerrada

        private void EscucharClientes(string ipAddress, int port)
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                _tcpListener.Start();
                _acceptThread = new Thread(AceptarClientes);
                _acceptThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }// EscucharClientes

        private void AceptarClientes()
        {
            do
            {
                try
                {
                    var conexion = _tcpListener.AcceptTcpClient();
                    var srvClient = new ConexionTcp(conexion)
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
        }// AceptarClientes

        private void LeerDatos(object client)
        {
            var cli = client as ConexionTcp;
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
                        //Convert all the character codes to their representable characters
                        for (int i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }
                        //Convert the character array to a string
                        var message = new string(chars);

                        //Invoke our event
                        OnDataRecieved(cli, message);
                    }
                    charBuffer.Clear();
                }
                catch (IOException)
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
        }// LeerDatos

        private void ServidorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }// ServidorForm_FormClosing

        private void btnMostrarCajeros_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCajeros.DataSource = conexiondb.obtenerCajeros();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// btnMostrarCajeros_Click

        private void btnAutorizarCajero_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCajeroUsuario.Text != "" && txtCajeroCaja.Text != "")
                {
                    if (conexiondb.validarUsuario(txtCajeroUsuario.Text) != 0)
                    {
                        if (conexiondb.validarCaja(Convert.ToInt32(txtCajeroCaja.Text)))
                        {
                            MessageBox.Show("Número de caja ya asignado a otro usuario.");
                        }
                        else
                        {
                            conexiondb.autorizarCajero(txtCajeroUsuario.Text, Convert.ToInt32(txtCajeroCaja.Text));
                            MessageBox.Show("Registro completado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un código de usuario y un número de caja para " +
                        "autorizar un cajero.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtCajeroUsuario.Clear();
            txtCajeroCaja.Clear();
        }// btnAutorizarCajero_Click

        private void btnInsertarCateg_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCategCod.Text != "" && txtCategDescrip.Text != "")
                {
                    Categoria categoria = new Categoria();
                    categoria.codigo = Convert.ToInt32(txtCategCod.Text);
                    categoria.descripcion = txtCategDescrip.Text;

                    conexiondb.insertarCategoria(categoria);
                    MessageBox.Show("Registro completado.");
                }
                else
                {
                    MessageBox.Show("Debe indicar un código y una descripción para la categoría.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtCategCod.Clear();
            txtCategDescrip.Clear();
        }// btnInsertarCateg_Click

        private void btnInsertarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtProdCod.Text != "" && txtProdDescrip.Text != "" && txtProdPrecio.Text != "" &&
                    txtProdCantidad.Text != "" && txtProdCodCateg.Text != "")
                {
                    if(conexiondb.validarCodCateg(Convert.ToInt32(txtProdCodCateg.Text)) != 0)
                    {
                        Producto producto = new Producto();
                        producto.codigo = Convert.ToInt32(txtProdCod.Text);
                        producto.descripcion = txtProdDescrip.Text;
                        producto.precio = Convert.ToDecimal(txtProdPrecio.Text);
                        producto.cantidad = Convert.ToInt32(txtProdCantidad.Text);
                        producto.categoriaCodigo = Convert.ToInt32(txtProdCodCateg.Text);

                        conexiondb.insertarProducto(producto);
                        MessageBox.Show("Registro completado.");
                    }
                    else
                    {
                        MessageBox.Show("Código de categoría no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los espacios para registrar el producto.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtProdCod.Clear();
            txtProdDescrip.Clear();
            txtProdPrecio.Clear();
            txtProdCantidad.Clear();
            txtProdCodCateg.Clear();
        }// btnInsertarProd_Click

        private void btnMostrarCateg_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCategorias.DataSource = conexiondb.obtenerCategorias();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// btnMostrarCateg_Click

        private void btnMostrarProd_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = conexiondb.obtenerProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// btnMostrarProd_Click

        private void btnActCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtActProdCant.Text != "" && txtActProdCod.Text != "")
                {
                    if( conexiondb.validarCodProducto(Convert.ToInt32(txtActProdCod.Text)) != 0)
                    {
                        conexiondb.actualizarCantidad(Convert.ToInt32(txtActProdCod.Text), 
                            Convert.ToInt32(txtActProdCant.Text));
                        MessageBox.Show("Registro completado.");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe indicar un código y una nueva cantidad para actualizar.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtActProdCant.Clear();
            txtActProdCod.Clear();
        }// btnActCantidad_Click

        private void btnActDescrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtActProdDescrip.Text != "" && txtActProdCod.Text != "")
                {
                    if (conexiondb.validarCodProducto(Convert.ToInt32(txtActProdCod.Text)) != 0)
                    {
                        conexiondb.actualizarDescripcion(Convert.ToInt32(txtActProdCod.Text), 
                            txtActProdDescrip.Text);
                        MessageBox.Show("Registro completado.");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe indicar un código y una nueva descripción para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtActProdDescrip.Clear();
            txtActProdCod.Clear();
        }// btnActDescrip_Click

        private void btnActPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtActProdPrecio.Text != "" && txtActProdCod.Text != "")
                {
                    if (conexiondb.validarCodProducto(Convert.ToInt32(txtActProdCod.Text)) != 0)
                    {
                        conexiondb.actualizarPrecio(Convert.ToInt32(txtActProdCod.Text),
                            Convert.ToDecimal(txtActProdPrecio.Text));
                        MessageBox.Show("Registro completado.");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe indicar un código y una nuevo precio para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtActProdPrecio.Clear();
            txtActProdCod.Clear();
        }// btnActPrecio_Click

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVentas.DataSource = conexiondb.obtenerVentas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// btnMostrarVentas_Click

    }// class FormServidor

}// namespace Servidor
