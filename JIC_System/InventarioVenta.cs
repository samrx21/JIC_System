using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace JIC_System
{
    public partial class InventarioVenta : Form
    {
        public event EventHandler ActualizarDataGridView;
        public InventarioVenta()
        {
            InitializeComponent();
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txChasis.Text) || string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txTelefono.Text))
            {
                lbMen.Text = "Debe rellenar toda la informacion.";
            }
            else
            {
                try
                {
                    long telefono = 0;
                    telefono = long.Parse(txTelefono.Text);
                    SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO");
                    string fecha = dtDate.Value.Year.ToString() + "/" + dtDate.Value.Month.ToString() + "/" + dtDate.Value.Day.ToString();
                    if (conexion != null)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("CrearVenta", conexion);
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregamos Parametros
                            cmd.Parameters.AddWithValue("@CedulaCliente", SqlDbType.VarChar).SqlValue = txCed.Text;
                            cmd.Parameters.AddWithValue("@NombreCliente", SqlDbType.VarChar).SqlValue = txNombre.Text;
                            cmd.Parameters.AddWithValue("@TelefonoCliente", SqlDbType.BigInt).SqlValue = telefono;
                            cmd.Parameters.AddWithValue("@TipoVenta", SqlDbType.VarChar).SqlValue = "CONTADO";
                            cmd.Parameters.AddWithValue("@EstadoVenta", SqlDbType.VarChar).SqlValue = "Vendida";
                            cmd.Parameters.AddWithValue("@FechaVenta", DateTime.Parse(fecha));
                            cmd.Parameters.AddWithValue("@ChasisMoto", SqlDbType.VarChar).SqlValue = txChasis.Text;
                            cmd.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

                            //Ejecutamos el Procedimineto
                            cmd.ExecuteNonQuery();

                            //Mostramos el valor OUTPUT del procedimiento
                            lbMen.Text = cmd.Parameters["@Mensaje"].Value.ToString();

                            
                            //Limpiamos
                            txChasis.Clear();
                            txNombre.Clear();
                            txCed.Clear();
                            txTelefono.Clear();

                            // Disparar el evento ActualizarDataGridView
                            ActualizarDataGridView?.Invoke(this, EventArgs.Empty);

                            txChasis.Focus();

                            //Cerramos la conexion
                            ControlDB.cerrar(conexion);
                        }
                        catch 
                        {
                            lbMen.Text = "Verifique los valores.";
                        }
                    }
                }
                catch
                {
                    lbMen.Text = "El telefono no debe contener letras.";
                }
            }
        }

        private void btTraspaso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txChasis.Text))
            {
                lbMen.Text = "Debe rellenar el campo 'Chasis'.";
            }
            else
            {
                try
                {
                    SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO");
                    if (conexion != null)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("CrearVenta", conexion);
                            cmd.CommandType = CommandType.StoredProcedure;
                            string fecha = dtDate.Value.Year.ToString() + "/" + dtDate.Value.Month.ToString() + "/" + dtDate.Value.Day.ToString();

                            // Agregamos Parametros
                            cmd.Parameters.AddWithValue("@CedulaCliente", SqlDbType.VarChar).SqlValue ="TRASPASO";
                            cmd.Parameters.AddWithValue("@NombreCliente", SqlDbType.VarChar).SqlValue = "TRASPASO";
                            cmd.Parameters.AddWithValue("@TelefonoCliente", SqlDbType.BigInt).SqlValue = 0;
                            cmd.Parameters.AddWithValue("@TipoVenta", SqlDbType.VarChar).SqlValue = "TRASPASO";
                            cmd.Parameters.AddWithValue("@EstadoVenta", SqlDbType.VarChar).SqlValue = "Vendida";
                            cmd.Parameters.AddWithValue("@FechaVenta", DateTime.Parse(fecha));
                            cmd.Parameters.AddWithValue("@ChasisMoto", SqlDbType.VarChar).SqlValue = txChasis.Text;
                            cmd.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

                            //Ejecutamos el Procedimineto
                            cmd.ExecuteNonQuery();

                            //Mostramos el valor OUTPUT del procedimiento
                            lbMen.Text = cmd.Parameters["@Mensaje"].Value.ToString();

                            //Limpiamos
                            txChasis.Clear();
                            txNombre.Clear();
                            txCed.Clear();
                            txTelefono.Clear();

                            // Disparar el evento ActualizarDataGridView
                            ActualizarDataGridView?.Invoke(this, EventArgs.Empty);

                            txChasis.Focus();

                            //Cerramos la conexion
                            ControlDB.cerrar(conexion);
                        }
                        catch
                        {
                            lbMen.Text = "Verifique los valores.";
                        }
                    }
                }
                catch
                {
                    lbMen.Text = "El telefono no debe contener letras.";
                }
            }
        }
    }
}
