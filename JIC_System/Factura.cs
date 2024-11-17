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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txId.Text) || String.IsNullOrEmpty(txValor.Text))
            {
                lbMen.Text = "Debe Ingresar toda la Información.";
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
                        string fecha = dtDate.Value.Year + "/" + dtDate.Value.Month + "/" + dtDate.Value.Day;
                        if (conexion != null)
                        {
                            int n = ControlDB.operar("INSERT INTO FACTURA VALUES('" + txId.Text + "'," + valor + ",'" + fecha + "')", conexion);
                            if (n > 0)
                            {
                                lbMen.Text = "Factura Ingresada."; 
                                txId.Text = "";
                                txValor.Text = "";
                                this.fACTURATableAdapter.Fill(this.dataSet1.FACTURA);
                                txId.Focus();
                            }
                            else
                            {
                                lbMen.Text = "La Factura ya existe.";
                            }
                            ControlDB.cerrar(conexion);
                        }
                    }
                }
                catch
                {
                    lbMen.Text = "El valor debe ser un número.";
                }
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.INVENTARIO1' Puede moverla o quitarla según sea necesario.
            this.iNVENTARIO1TableAdapter.Fill(this.dataSet1.INVENTARIO1);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.dataSet1.FACTURA);

        }
    }
}
