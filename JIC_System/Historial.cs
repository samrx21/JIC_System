using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIC_System
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarVentasVendidas();
        }
        private void CargarVentasVendidas()
        {
            string consulta = "SELECT  I.NOMBRE,V.CHASISMOTO AS CHASIS,V.TIPOVENTA, V.FECHAVEN, I.VALOR,C.NOMBRE AS CLIENTE, C.CEDULA, C.TELEFONO " +
                              "FROM VENTA AS V INNER JOIN INVENTARIO AS I ON V.CHASISMOTO = I.CHASIS " +
                              "INNER JOIN  CLIENTE AS C ON V.CEDULACLIENTE = C.CEDULA " +
                              "WHERE V.ESTADO = 'Vendida'";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dataGridViewVentas.DataSource = tabla;
                conexion.Close();
            }
        }

        private void FiltrarPorChasisCliente(string bus)
        {
            string consulta = "SELECT  I.NOMBRE,V.CHASISMOTO AS CHASIS,V.TIPOVENTA, V.FECHAVEN, I.VALOR,C.NOMBRE AS CLIENTE, C.CEDULA, C.TELEFONO " +
                              "FROM VENTA AS V INNER JOIN INVENTARIO AS I ON V.CHASISMOTO = I.CHASIS " +
                              "INNER JOIN  CLIENTE AS C ON V.CEDULACLIENTE = C.CEDULA " +
                              "WHERE V.CHASISMOTO = @Chasis OR V.CEDULACLIENTE = @Cedula";

            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Chasis", bus);
                comando.Parameters.AddWithValue("@Cedula", bus);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dataGridViewVentas.DataSource = tabla;
                conexion.Close();
            }
        }


        private void FiltrarPorRangoFechas(DateTime fechaInicio, DateTime fechaFin, string Tipo)
        {
            string consulta = "SELECT  I.NOMBRE,V.CHASISMOTO AS CHASIS,V.TIPOVENTA, V.FECHAVEN, I.VALOR,C.NOMBRE AS CLIENTE, C.CEDULA, C.TELEFONO " +
                             "FROM VENTA AS V INNER JOIN INVENTARIO AS I ON V.CHASISMOTO = I.CHASIS " +
                            "INNER JOIN  CLIENTE AS C ON V.CEDULACLIENTE = C.CEDULA " +
                            "WHERE (V.FECHAVEN BETWEEN @FechaInicio AND @FechaFin) AND (V.ESTADO = 'Vendida')";

            if (Tipo != "")
            {
                consulta = "SELECT  I.NOMBRE,V.CHASISMOTO AS CHASIS,V.TIPOVENTA, V.FECHAVEN, I.VALOR,C.NOMBRE AS CLIENTE, C.CEDULA, C.TELEFONO " +
                                "FROM VENTA AS V INNER JOIN INVENTARIO AS I ON V.CHASISMOTO = I.CHASIS " +
                               "INNER JOIN  CLIENTE AS C ON V.CEDULACLIENTE = C.CEDULA " +
                               "WHERE (V.FECHAVEN BETWEEN @FechaInicio AND @FechaFin) AND (V.ESTADO = 'Vendida') AND (I.TIPO ='" + Tipo + "')";
            }


            using (SqlConnection conexion = ControlDB.conectar("JINCONSESIONARIO"))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                comando.Parameters.AddWithValue("@FechaFin", fechaFin);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dataGridViewVentas.DataSource = tabla;

                // Calcular la suma del campo Valor
                decimal sumaValor = 0;
                foreach (DataRow fila in tabla.Rows)
                {
                    sumaValor += Convert.ToDecimal(fila["VALOR"]);
                }

                txSumaValor.Text = sumaValor.ToString();
                txCant.Text = dataGridViewVentas.RowCount.ToString();
                conexion.Close();
            }
        }

        private void btVentasFech_Click(object sender, EventArgs e)
        {
            string Tipo = "";

            txSearch.Clear();
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;


            if (rbMoto.Checked == true)
                Tipo = "Moto";

            if (rbMotocarro.Checked == true)
                Tipo = "Motocarro";


            FiltrarPorRangoFechas(fechaInicio, fechaFin, Tipo);
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txSearch.Text))
            {
                CargarVentasVendidas();
            }
            else
            {
                string filtro = txSearch.Text;
                FiltrarPorChasisCliente(filtro);
            }
        }
    }
}
