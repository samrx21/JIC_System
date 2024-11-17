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
    public partial class InventarioCredito : Form
    {
        public event EventHandler ActualizarDataGridView;
        public InventarioCredito()
        {
            InitializeComponent();
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txChasis.Text) || string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txCed.Text) ||
                string.IsNullOrEmpty(txTelefono.Text) || string.IsNullOrEmpty(txCuotaInc.Text) || string.IsNullOrEmpty(txValorCuo.Text))
            {
                lbMen.Text = "Debe rellenar toda la informacion.";
            }
            else
            {
                try
                {
                    long telefono = 0;
                    double cuota = 0;
                    double valorCuo = 0;
                    telefono = long.Parse(txTelefono.Text);
                    cuota = Double.Parse(txCuotaInc.Text);
                    valorCuo = Double.Parse(txValorCuo.Text);
                    SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO");
                    string fecha = dtDate.Value.Year.ToString() + "/" + dtDate.Value.Month.ToString() + "/" + dtDate.Value.Day.ToString();
                    if (conexion != null)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("CrearCredito", conexion);
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregamos Parametros
                            cmd.Parameters.AddWithValue("@CedulaCliente", SqlDbType.VarChar).SqlValue = txCed.Text;
                            cmd.Parameters.AddWithValue("@NombreCliente", SqlDbType.VarChar).SqlValue = txNombre.Text;
                            cmd.Parameters.AddWithValue("@TelefonoCliente", SqlDbType.BigInt).SqlValue = telefono;
                            cmd.Parameters.AddWithValue("@TipoVenta", SqlDbType.VarChar).SqlValue = "CREDITO";
                            cmd.Parameters.AddWithValue("@EstadoVenta", SqlDbType.VarChar).SqlValue = "Credito";
                            cmd.Parameters.AddWithValue("@FechaVenta", DateTime.Parse(fecha));
                            cmd.Parameters.AddWithValue("@ChasisMoto", SqlDbType.VarChar).SqlValue = txChasis.Text;
                            cmd.Parameters.AddWithValue("@CuotaIcic", SqlDbType.Money).SqlValue = cuota;
                            cmd.Parameters.AddWithValue("@ValorCuotas", SqlDbType.Money).SqlValue = valorCuo;
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
                            txCuotaInc.Clear();
                            txValorCuo.Clear();

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
                    lbMen.Text = "El telefono y valores de dinero no deben contener letras.";
                }
            }
        }
    }
}
