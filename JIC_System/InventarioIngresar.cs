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
    public partial class InventarioIngresar : Form
    {
        public event EventHandler ActualizarDataGridView;
        public InventarioIngresar()
        {
            InitializeComponent();
            
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txChasis.Text) || String.IsNullOrEmpty(txNombre.Text) || String.IsNullOrEmpty(txModelo.Text) || String.IsNullOrEmpty(lbTipo.Text) || String.IsNullOrEmpty(txValor.Text) || String.IsNullOrEmpty(lbFactura.Text))
            {
                lbMen.Text = "Debe rellenar toda la informacion.";
            }
            else
            {
                try
                {
                    double valor = 0;
                    valor = Double.Parse(txValor.Text);
                    if (valor <= 0)
                    {
                        lbMen.Text = "El valor debe ser un número mayor que cero.";
                    }
                    else
                    {
                        SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO");
                        string fecha = dtDate.Value.Year.ToString() + "/" + dtDate.Value.Month.ToString() + "/" + dtDate.Value.Day.ToString();
                        if (conexion != null)
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand("InsertarAInventario", conexion);
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregamos Parametros
                                cmd.Parameters.AddWithValue("@Chasis", SqlDbType.VarChar).SqlValue = txChasis.Text;
                                cmd.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).SqlValue = txNombre.Text;
                                cmd.Parameters.AddWithValue("@Modelo", SqlDbType.VarChar).SqlValue = txModelo.Text;
                                cmd.Parameters.AddWithValue("@Tipo", SqlDbType.VarChar).SqlValue = lbTipo.Text;
                                cmd.Parameters.AddWithValue("@Valor", SqlDbType.Money).SqlValue = valor;
                                cmd.Parameters.AddWithValue("@FechaIn", DateTime.Parse(fecha));
                                cmd.Parameters.AddWithValue("@IdFac", SqlDbType.VarChar).SqlValue = lbFactura.Text;
                                cmd.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

                                //Ejecutamos el Procedimineto
                                int n = cmd.ExecuteNonQuery();

                                //Mostramos el valor OUTPUT del procedimiento
                                lbMen.Text = cmd.Parameters["@Mensaje"].Value.ToString();
                                
                                //Cerramos la conexion
                                ControlDB.cerrar(conexion);
                                if (n > 0)
                                {
                                    //Limpiamos
                                    txChasis.Clear();
                                    txNombre.Clear();
                                    txModelo.Clear();
                                    txValor.Clear();

                                    // Disparar el evento ActualizarDataGridView
                                    ActualizarDataGridView?.Invoke(this, EventArgs.Empty);
                                }

                                //Cargamos registros
                                this.fACTURATableAdapter.Fill(this.dataSet1.FACTURA);

                                txChasis.Focus();
                            }
                            catch
                            {
                                lbMen.Text = "Verifique los valores.";
                            }
                        }
                    }
                }
                catch
                {
                    lbMen.Text = "El valor debe ser un número.";
                }
            }
        }

        private void InventarioIngresar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.dataSet1.FACTURA);

        }
    }
}
