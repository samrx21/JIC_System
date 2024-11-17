using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIC_System
{
    public partial class Inventario : Form
    {

        private Form currentChildForm;
        public Inventario()
        {
            InitializeComponent();
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.INVENTARIO' Puede moverla o quitarla según sea necesario.
            this.iNVENTARIOTableAdapter.Fill(this.dataSet1.INVENTARIO);
        }
        private void btIngresar_Click(object sender, EventArgs e)
        {
            OpenFormHijo(1);
        }

        private void btVenta_Click(object sender, EventArgs e)
        {
            OpenFormHijo(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormHijo(3);
        }


        private void OpenFormHijo(int formType)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            if (formType == 1)
            {
                InventarioIngresar chieldForm = new InventarioIngresar();
                // Suscribirse al evento ActualizarDataGridView del formulario hijo
                chieldForm.ActualizarDataGridView += Inventario_Load;

                OpenFormHijoAux(chieldForm);
            }
            else if (formType == 2)
            {
                InventarioVenta chieldForm = new InventarioVenta();
                // Suscribirse al evento ActualizarDataGridView del formulario hijo
                chieldForm.ActualizarDataGridView += Inventario_Load;

                OpenFormHijoAux(chieldForm);
            }
            else
            {
                InventarioCredito chieldForm = new InventarioCredito();
                // Suscribirse al evento ActualizarDataGridView del formulario hijo
                chieldForm.ActualizarDataGridView += Inventario_Load;

                OpenFormHijoAux(chieldForm);
            }
        }

        private void OpenFormHijoAux(Form chieldForm)
        {
            currentChildForm = chieldForm;
            chieldForm.TopLevel = false;
            chieldForm.Dock = DockStyle.Fill;
            PanelInv.Controls.Add(chieldForm);
            chieldForm.BringToFront();
            chieldForm.Show();
        }
    }
}
