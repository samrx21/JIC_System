using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using FontAwesome.Sharp;

namespace JIC_System
{

    public partial class Main : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            panelMenu.Controls.Add(leftBorderBtn);
            
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //Structura para los colores
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(249, 88, 155);
        }

        //Al activarse Button
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(18, 17, 38);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign= ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //borde izquierdo del button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location= new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible=true;
                leftBorderBtn.BringToFront();

                //Icono del formulario hijo actual
                iconFormHijoAct.IconChar = currentBtn.IconChar;
                iconFormHijoAct.IconColor= color;
                lbTituloFormHijo.Text = currentBtn.Text;
            }
        }

        //Para desactivar button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(16, 5, 42);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        //Abrir Formularios HIjos
        private void OpenFormHijo(Form chieldForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = chieldForm;
            chieldForm.TopLevel = false;
            chieldForm.FormBorderStyle = FormBorderStyle.None;
            chieldForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(chieldForm);
            panelDesktop.Tag = chieldForm;
            chieldForm.BringToFront();
            chieldForm.Show();
            lbTituloFormHijo.Text=chieldForm.Text;
        }



        private void btFactura_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenFormHijo(new Factura());
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenFormHijo(new Inventario());
        }

        private void btHistorial_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenFormHijo(new Historial());
        }

        private void btCreditos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenFormHijo(new Creditos());
        }

       
        private void btHome_Click_1(object sender, EventArgs e)
        {
            if(currentChildForm!= null)
                currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            //Buttons
            DisableButton();
            leftBorderBtn.Visible= false;

            //Icono del formulario hijo actual
            iconFormHijoAct.IconChar = IconChar.Home;
            iconFormHijoAct.IconColor = Color.FromArgb(219, 46, 242);
            lbTituloFormHijo.Text = "Inicio";
        }


        //Arastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012,0);
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
