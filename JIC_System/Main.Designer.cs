namespace JIC_System
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btCreditos = new FontAwesome.Sharp.IconButton();
            this.btHistorial = new FontAwesome.Sharp.IconButton();
            this.btInventario = new FontAwesome.Sharp.IconButton();
            this.btFactura = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btMinimizar = new FontAwesome.Sharp.IconButton();
            this.btMaximizar = new FontAwesome.Sharp.IconButton();
            this.btCerrar = new FontAwesome.Sharp.IconButton();
            this.lbTituloFormHijo = new System.Windows.Forms.Label();
            this.iconFormHijoAct = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoAct)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.panelMenu.Controls.Add(this.btCreditos);
            this.panelMenu.Controls.Add(this.btHistorial);
            this.panelMenu.Controls.Add(this.btInventario);
            this.panelMenu.Controls.Add(this.btFactura);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 491);
            this.panelMenu.TabIndex = 0;
            // 
            // btCreditos
            // 
            this.btCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCreditos.FlatAppearance.BorderSize = 0;
            this.btCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreditos.Font = new System.Drawing.Font("Calibri", 16F);
            this.btCreditos.ForeColor = System.Drawing.Color.White;
            this.btCreditos.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btCreditos.IconColor = System.Drawing.Color.White;
            this.btCreditos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCreditos.IconSize = 32;
            this.btCreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCreditos.Location = new System.Drawing.Point(0, 335);
            this.btCreditos.Name = "btCreditos";
            this.btCreditos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btCreditos.Size = new System.Drawing.Size(240, 65);
            this.btCreditos.TabIndex = 4;
            this.btCreditos.Text = "Creditos";
            this.btCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCreditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCreditos.UseVisualStyleBackColor = true;
            this.btCreditos.Click += new System.EventHandler(this.btCreditos_Click);
            // 
            // btHistorial
            // 
            this.btHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHistorial.FlatAppearance.BorderSize = 0;
            this.btHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistorial.Font = new System.Drawing.Font("Calibri", 16F);
            this.btHistorial.ForeColor = System.Drawing.Color.White;
            this.btHistorial.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btHistorial.IconColor = System.Drawing.Color.White;
            this.btHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHistorial.IconSize = 32;
            this.btHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHistorial.Location = new System.Drawing.Point(0, 270);
            this.btHistorial.Name = "btHistorial";
            this.btHistorial.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btHistorial.Size = new System.Drawing.Size(240, 65);
            this.btHistorial.TabIndex = 3;
            this.btHistorial.Text = "Historial";
            this.btHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHistorial.UseVisualStyleBackColor = true;
            this.btHistorial.Click += new System.EventHandler(this.btHistorial_Click);
            // 
            // btInventario
            // 
            this.btInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInventario.FlatAppearance.BorderSize = 0;
            this.btInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInventario.Font = new System.Drawing.Font("Calibri", 16F);
            this.btInventario.ForeColor = System.Drawing.Color.White;
            this.btInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btInventario.IconColor = System.Drawing.Color.White;
            this.btInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btInventario.IconSize = 32;
            this.btInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInventario.Location = new System.Drawing.Point(0, 205);
            this.btInventario.Name = "btInventario";
            this.btInventario.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btInventario.Size = new System.Drawing.Size(240, 65);
            this.btInventario.TabIndex = 2;
            this.btInventario.Text = "Inventario";
            this.btInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInventario.UseVisualStyleBackColor = true;
            this.btInventario.Click += new System.EventHandler(this.btInventario_Click);
            // 
            // btFactura
            // 
            this.btFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.btFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFactura.FlatAppearance.BorderSize = 0;
            this.btFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFactura.Font = new System.Drawing.Font("Calibri", 16F);
            this.btFactura.ForeColor = System.Drawing.Color.White;
            this.btFactura.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btFactura.IconColor = System.Drawing.Color.White;
            this.btFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btFactura.IconSize = 30;
            this.btFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFactura.Location = new System.Drawing.Point(0, 140);
            this.btFactura.Name = "btFactura";
            this.btFactura.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btFactura.Size = new System.Drawing.Size(240, 65);
            this.btFactura.TabIndex = 1;
            this.btFactura.Text = "Facturas";
            this.btFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFactura.UseVisualStyleBackColor = false;
            this.btFactura.Click += new System.EventHandler(this.btFactura_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 140);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(21)))), ((int)(((byte)(143)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 15);
            this.panel1.TabIndex = 1;
            // 
            // btHome
            // 
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(240, 140);
            this.btHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btHome.TabIndex = 0;
            this.btHome.TabStop = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click_1);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.panelTitleBar.Controls.Add(this.btMinimizar);
            this.panelTitleBar.Controls.Add(this.btMaximizar);
            this.panelTitleBar.Controls.Add(this.btCerrar);
            this.panelTitleBar.Controls.Add(this.lbTituloFormHijo);
            this.panelTitleBar.Controls.Add(this.iconFormHijoAct);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Calibri", 12F);
            this.panelTitleBar.Location = new System.Drawing.Point(240, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(735, 65);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.ForeColor = System.Drawing.Color.White;
            this.btMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btMinimizar.IconColor = System.Drawing.Color.White;
            this.btMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMinimizar.IconSize = 20;
            this.btMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMinimizar.Location = new System.Drawing.Point(612, 4);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(36, 24);
            this.btMinimizar.TabIndex = 4;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.btMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.ForeColor = System.Drawing.Color.White;
            this.btMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btMaximizar.IconColor = System.Drawing.Color.White;
            this.btMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMaximizar.IconSize = 20;
            this.btMaximizar.Location = new System.Drawing.Point(654, 4);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(36, 24);
            this.btMaximizar.TabIndex = 3;
            this.btMaximizar.UseVisualStyleBackColor = false;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.FlatAppearance.BorderSize = 0;
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.ForeColor = System.Drawing.Color.White;
            this.btCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btCerrar.IconColor = System.Drawing.Color.White;
            this.btCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCerrar.IconSize = 20;
            this.btCerrar.Location = new System.Drawing.Point(696, 4);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(36, 24);
            this.btCerrar.TabIndex = 2;
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // lbTituloFormHijo
            // 
            this.lbTituloFormHijo.AutoSize = true;
            this.lbTituloFormHijo.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbTituloFormHijo.ForeColor = System.Drawing.Color.White;
            this.lbTituloFormHijo.Location = new System.Drawing.Point(68, 22);
            this.lbTituloFormHijo.Name = "lbTituloFormHijo";
            this.lbTituloFormHijo.Size = new System.Drawing.Size(55, 24);
            this.lbTituloFormHijo.TabIndex = 1;
            this.lbTituloFormHijo.Text = "Inicio";
            // 
            // iconFormHijoAct
            // 
            this.iconFormHijoAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(42)))));
            this.iconFormHijoAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(46)))), ((int)(((byte)(242)))));
            this.iconFormHijoAct.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconFormHijoAct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(46)))), ((int)(((byte)(242)))));
            this.iconFormHijoAct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormHijoAct.IconSize = 35;
            this.iconFormHijoAct.Location = new System.Drawing.Point(18, 15);
            this.iconFormHijoAct.Name = "iconFormHijoAct";
            this.iconFormHijoAct.Size = new System.Drawing.Size(43, 35);
            this.iconFormHijoAct.TabIndex = 0;
            this.iconFormHijoAct.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(240, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(735, 426);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::JIC_System.Properties.Resources.JIC__1_;
            this.pictureBox1.Location = new System.Drawing.Point(130, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 491);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(700, 530);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoAct)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btCreditos;
        private FontAwesome.Sharp.IconButton btHistorial;
        private FontAwesome.Sharp.IconButton btInventario;
        private FontAwesome.Sharp.IconButton btFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconFormHijoAct;
        private System.Windows.Forms.Label lbTituloFormHijo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btHome;
        private FontAwesome.Sharp.IconButton btCerrar;
        private FontAwesome.Sharp.IconButton btMaximizar;
        private FontAwesome.Sharp.IconButton btMinimizar;
        private System.Windows.Forms.Panel panel1;
    }
}

