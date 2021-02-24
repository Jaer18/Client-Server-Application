using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public class ConexionBD
    {
        private string cadenaConexion;

        public ConexionBD()
        {
            cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BuenPrecioProyecto;Integrated Security=True";
        }// ConexionBD

        public void InsertarCajero(Cajero pCajero)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "insert into Cajero(Usuario, Nombre, PrimerApellido, SegundoApellido, CajaAsignada, Activo) " +
                "values(@Usuario, @Nombre, @PrimerApellido, @SegundoApellido, @CajaAsignada, @Activo)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Usuario", pCajero.usuario);
            comando.Parameters.AddWithValue("@Nombre", pCajero.nombre);
            comando.Parameters.AddWithValue("@PrimerApellido", pCajero.primerAp);
            comando.Parameters.AddWithValue("@SegundoApellido", pCajero.segundoAp);
            comando.Parameters.AddWithValue("@CajaAsignada", pCajero.cajaAsignada);
            comando.Parameters.AddWithValue("@Activo", pCajero.activo);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// InsertarCajero

        public void insertarCategoria(Categoria pCategoria)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "insert into Categoria(Codigo, Descripcion) " +
                "values(@Codigo, @Descripcion)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Codigo", pCategoria.codigo);
            comando.Parameters.AddWithValue("@Descripcion", pCategoria.descripcion);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// insertarCategoria

        public void insertarProducto(Producto pProducto)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "insert into Producto(Codigo, Descripcion, Precio, Cantidad, CodigoCategoria) " +
                "values(@Codigo, @Descripcion, @Precio, @Cantidad, @CodigoCategoria)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Codigo", pProducto.codigo);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.descripcion);
            comando.Parameters.AddWithValue("@Precio", pProducto.precio);
            comando.Parameters.AddWithValue("@Cantidad", pProducto.cantidad);
            comando.Parameters.AddWithValue("@CodigoCategoria", pProducto.categoriaCodigo);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// insertarProducto

        public void insertarVenta(Venta pVenta)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "insert into Venta(UsuarioCodigo, Fecha, CodigoProducto, Precio, Cantidad, Montototal) " +
                "values(@UsuarioCodigo, @Fecha, @CodigoProducto, @Precio, @Cantidad, @Montototal)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@UsuarioCodigo", pVenta.cajeroUsuario);
            comando.Parameters.AddWithValue("@Fecha", pVenta.fecha);
            comando.Parameters.AddWithValue("@CodigoProducto", pVenta.codigoProducto);
            comando.Parameters.AddWithValue("@Precio", pVenta.precioProducto);
            comando.Parameters.AddWithValue("@Cantidad", pVenta.cantidad);
            comando.Parameters.AddWithValue("@Montototal", pVenta.montoTotal);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// insertarVenta

        public void autorizarCajero(string pUsuario, int pCajaAsignada)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "update Cajero " +
                        "set CajaAsignada = @CajaAsignada, Activo = 1 " +
                        "where Usuario = @Usuario";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Usuario", pUsuario);
            comando.Parameters.AddWithValue("@CajaAsignada", pCajaAsignada);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// autorizarCajero

        public int validarUsuario(string pUsuario)
        {
            SqlConnection conexion;
            SqlCommand command;
            SqlDataReader dataReader;
            conexion = new SqlConnection(cadenaConexion);
            int contador = 0;
            try
            {
                conexion.Open();
                command = new SqlCommand("Select * from Cajero where Usuario=" + pUsuario + "", conexion);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    contador++;
                }
                dataReader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro consultar en la base de datos: " + ex.Message);
            }
            return contador;
        }// validarUsuario

        public int validarCodCateg(int pCodCateg)
        {
            SqlConnection conexion;
            SqlCommand command;
            SqlDataReader dataReader;
            conexion = new SqlConnection(cadenaConexion);
            int contador = 0;
            try
            {
                conexion.Open();
                command = new SqlCommand("Select * from Categoria where Codigo=" + pCodCateg + "", conexion);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    contador++;
                }
                dataReader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro consultar en la base de datos: " + ex.Message);
            }
            return contador;
        }// validarCodCateg

        public int validarCodProducto(int pCodigoProducto)
        {
            SqlConnection conexion;
            SqlCommand command;
            SqlDataReader dataReader;
            conexion = new SqlConnection(cadenaConexion);
            int contador = 0;
            try
            {
                conexion.Open();
                command = new SqlCommand("Select * from Producto where Codigo=" + pCodigoProducto + "", conexion);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    contador++;
                }
                dataReader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro consultar en la base de datos: " + ex.Message);
            }
            return contador;
        }// validarCodProducto

        public void actualizarCantidad(int pCodigoProducto, int pNuevaCantidad)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "update Producto " +
                        "set Cantidad = @Cantidad " +
                        "where Codigo = @Codigo";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Codigo", pCodigoProducto);
            comando.Parameters.AddWithValue("@Cantidad", pNuevaCantidad);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// actualizarCantidad

        public void actualizarPrecio(int pCodigoProducto, decimal pNuevoPrecio)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "update Producto " +
                        "set Precio = @Precio " +
                        "where Codigo = @Codigo";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Codigo", pCodigoProducto);
            comando.Parameters.AddWithValue("@Precio", pNuevoPrecio);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// actualizarPrecio

        public void actualizarDescripcion(int pCodigoProducto, string pNuevaDescrip)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "update Producto " +
                        "set Descripcion = @Descripcion " +
                        "where Codigo = @Codigo";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Codigo", pCodigoProducto);
            comando.Parameters.AddWithValue("@Descripcion", pNuevaDescrip);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }// actualizarDescripcion

        public bool esActivo(string pUsuario)
        {
            bool esActivo = false;

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select Activo From Cajero Where Usuario = " + "'" + pUsuario + "'";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    esActivo = reader.GetBoolean(0);
                }
            }

            conexion.Close();
            return esActivo;
        }// esActivo

        public decimal obtenerPrecio(int pCodProd)
        {
            decimal precio = 0;

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select Precio From Producto Where Codigo = " + "" + pCodProd + "";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    precio = reader.GetDecimal(0);
                }
            }

            conexion.Close();
            return precio;
        }// obtenerPrecio

        public int obtenerCantidad(int pCodProd)
        {
            int cantidad = 0;

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select Cantidad From Producto Where Codigo = " + "" + pCodProd + "";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;


            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cantidad = reader.GetInt32(0);
                }
            }

            conexion.Close();
            return cantidad;
        }// obtenerCantidad

        public bool validarCaja(int pCajaAsg)
        {
            bool cajaUsada = false;
            int cajaAsg;

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select CajaAsignada From Cajero ";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cajaAsg = reader.GetInt32(0);
                    if(cajaAsg == pCajaAsg)
                    {
                        cajaUsada = true;
                        return cajaUsada;
                    }
                }
            }

            conexion.Close();
            return cajaUsada;
        }// validarCaja

        public List<Cajero> obtenerCajeros()
        {
            List<Cajero> listaCajeros = new List<Cajero>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select Usuario, Nombre, PrimerApellido, SegundoApellido, CajaAsignada, Activo" +
                        " From Cajero order by CajaAsignada asc";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaCajeros.Add(new Cajero
                    {
                        usuario = reader.GetString(0),
                        nombre = reader.GetString(1),
                        primerAp = reader.GetString(2),
                        segundoAp = reader.GetString(3),
                        cajaAsignada = reader.GetInt32(4),
                        activo = reader.GetBoolean(5)
                    });
                }
            }

            conexion.Close();

            return listaCajeros;
        }// obtenerCajeros

        public List<Categoria> obtenerCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select Codigo, Descripcion" +
                        " From Categoria";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaCategorias.Add(new Categoria
                    {
                        codigo = reader.GetInt32(0),
                        descripcion = reader.GetString(1),
                    });
                }
            }

            conexion.Close();

            return listaCategorias;
        }// obtenerCategorias

        public List<Producto> obtenerProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select Codigo, Descripcion, Precio, Cantidad, CodigoCategoria" +
                        " From Producto";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaProductos.Add(new Producto
                    {
                        codigo = reader.GetInt32(0),
                        descripcion = reader.GetString(1),
                        precio = reader.GetDecimal(2),
                        cantidad = reader.GetInt32(3),
                        categoriaCodigo = reader.GetInt32(4)
                    });
                }
            }

            conexion.Close();

            return listaProductos;
        }// obtenerProductos

        public List<Venta> obtenerVentas()
        {
            List<Venta> listaVentas = new List<Venta>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Select UsuarioCodigo, Fecha, CodigoProducto, Precio, Cantidad, Montototal, Codigo" +
                        " From Venta";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaVentas.Add(new Venta
                    {
                        cajeroUsuario = reader.GetString(0),
                        fecha = reader.GetDateTime(1),
                        codigoProducto = reader.GetInt32(2),
                        precioProducto = reader.GetDecimal(3),
                        cantidad = reader.GetInt32(4),
                        montoTotal = reader.GetDecimal(5),
                        codigo = reader.GetInt32(6)
                    });
                }
            }

            conexion.Close();

            return listaVentas;
        }// obtenerVentas

    }// class ConexionBD
}
