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

namespace JIC_System
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }
        private void Creditos_Load(object sender, EventArgs e)
        {
            CargarDatosGrid();
        }
        private void CargarDatosGrid()
        {
            string consulta = "SELECT V.CHASISMOTO AS CHASIS, C.CEDULA, C.NOMBRE, C.TELEFONO, " +
                "I.VALOR, CR.CAPITALINIC, CR.VALORCUOTAS, CR.PAGADO, I.VALOR - CR.CAPITALINIC - CR.PAGADO AS DEBE , CR.PROXFECHAPAGO " +
                "FROM INVENTARIO AS I INNER JOIN VENTA AS V  ON I.CHASIS = V.CHASISMOTO " +
                "INNER JOIN CLIENTE AS C ON V.CEDULACLIENTE = C.CEDULA " +
                "INNER JOIN CREDITO AS CR ON V.ID = CR.IDVENTA";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dataGridViewDatos.DataSource = tabla;
                ControlDB.cerrar(conexion);
            }
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDatos.SelectedRows.Count > 0)
            {
                string chasis = dataGridViewDatos.SelectedRows[0].Cells["CHASIS"].Value.ToString();

                // Obtener los valores actuales de PAGADO y PROXFECHAPAGO
                decimal pagadoActual = Convert.ToDecimal(dataGridViewDatos.SelectedRows[0].Cells["PAGADO"].Value);
                DateTime proxFechaPagoActual = Convert.ToDateTime(dataGridViewDatos.SelectedRows[0].Cells["PROXFECHAPAGO"].Value);

                // Obtener el valor de las cuotas
                decimal valorCuotas = Convert.ToDecimal(dataGridViewDatos.SelectedRows[0].Cells["VALORCUOTAS"].Value);

                // OBtener el capital inicial
                decimal capitalInic = Convert.ToDecimal(dataGridViewDatos.SelectedRows[0].Cells["CAPITALINIC"].Value);

                // Calcular el nuevo valor de PAGADO y PROXFECHAPAGO
                decimal nuevoPagado = pagadoActual + valorCuotas;
                DateTime nuevaProxFechaPago = proxFechaPagoActual.AddMonths(1);

                // Actualizar los datos en la base de datos
                ActualizarPagadoProxFechaPago(chasis, nuevoPagado, nuevaProxFechaPago);

                // Verificar si el valor de PAGADO es igual o mayor al valor de la tabla INVENTARIO
                if (capitalInic + nuevoPagado >= ObtenerValorInventario(chasis))
                {
                    ActualizarEstadoVenta(chasis);
                    EliminarCredito(chasis);
                    lbMen.Text = "El cliente ha terminado de pagar el credito.";
                }
                else
                {
                    lbMen.Text = "El cliente a pagado la cuota exitosamente.";
                }

                // Volver a cargar los datos en el DataGridView
                CargarDatosGrid();
            }
        }

        private decimal ObtenerValorInventario(string chasis)
        {
            string consulta = "SELECT VALOR FROM INVENTARIO WHERE CHASIS = @Chasis";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Chasis", chasis);

                decimal valorInventario = Convert.ToDecimal(comando.ExecuteScalar());
                conexion.Close();

                return valorInventario;
            }
        }

        private void ActualizarPagadoProxFechaPago(string chasis, decimal nuevoPagado, DateTime nuevaProxFechaPago)
        {
            string consulta = "UPDATE CREDITO SET PAGADO = @Pagado, PROXFECHAPAGO = @ProxFechaPago " +
                "FROM CREDITO AS CR " +
                "INNER JOIN VENTA AS V ON CR.IDVENTA = V.ID " +
                "WHERE V.CHASISMOTO = @Chasis";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Pagado", nuevoPagado);
                comando.Parameters.AddWithValue("@ProxFechaPago", nuevaProxFechaPago);
                comando.Parameters.AddWithValue("@Chasis", chasis);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }

        private void ActualizarEstadoVenta(string chasis)
        {
            string consulta = "UPDATE VENTA SET ESTADO = 'Vendida' WHERE CHASISMOTO = @Chasis";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Chasis", chasis);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }

        private void EliminarCredito(string chasis)
        {
            string consulta = "DELETE FROM CREDITO WHERE IDVENTA IN " +
                "(SELECT V.ID FROM VENTA AS V INNER JOIN INVENTARIO AS I ON V.CHASISMOTO = I.CHASIS " +
                "WHERE I.CHASIS = @Chasis)";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Chasis", chasis);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }
        private void FiltrarPorChasisCliente(string bus)
        {
            string consulta = "SELECT V.CHASISMOTO AS CHASIS, C.CEDULA, C.NOMBRE, C.TELEFONO, " +
                "CR.CAPITALINIC, CR.PAGADO, CR.VALORCUOTAS, CR.PROXFECHAPAGO " +
                "FROM VENTA AS V " +
                "INNER JOIN CLIENTE AS C ON V.CEDULACLIENTE = C.CEDULA " +
                "INNER JOIN CREDITO AS CR ON V.ID = CR.IDVENTA " +
                "WHERE V.CHASISMOTO = @Chasis OR V.CEDULACLIENTE = @Cedula";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Chasis", bus);
                comando.Parameters.AddWithValue("@Cedula", bus);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                try
                {
                    adaptador.Fill(tabla);
                }
                catch(SqlException ex) { MessageBox.Show(""+ex); }

                dataGridViewDatos.DataSource = tabla;
                conexion.Close();
            }
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txSearch.Text))
            {
                CargarDatosGrid();
            }
            else
            {
                string filtro = txSearch.Text;
                FiltrarPorChasisCliente(filtro);
            }
        }
    }
}
