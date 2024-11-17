namespace JIC_System
{
    partial class InventarioVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.btTraspaso = new System.Windows.Forms.Button();
            this.btVender = new System.Windows.Forms.Button();
            this.lbMen = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txCed = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txChasis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.btTraspaso);
            this.gbVenta.Controls.Add(this.btVender);
            this.gbVenta.Controls.Add(this.lbMen);
            this.gbVenta.Controls.Add(this.dtDate);
            this.gbVenta.Controls.Add(this.txTelefono);
            this.gbVenta.Controls.Add(this.txCed);
            this.gbVenta.Controls.Add(this.txNombre);
            this.gbVenta.Controls.Add(this.txChasis);
            this.gbVenta.Controls.Add(this.label7);
            this.gbVenta.Controls.Add(this.label6);
            this.gbVenta.Controls.Add(this.label5);
            this.gbVenta.Controls.Add(this.label3);
            this.gbVenta.Controls.Add(this.label2);
            this.gbVenta.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.gbVenta.ForeColor = System.Drawing.Color.White;
            this.gbVenta.Location = new System.Drawing.Point(1, 1);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(438, 357);
            this.gbVenta.TabIndex = 5;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Venta Moto";
            // 
            // btTraspaso
            // 
            this.btTraspaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.btTraspaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTraspaso.FlatAppearance.BorderSize = 0;
            this.btTraspaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraspaso.Font = new System.Drawing.Font("Calibri", 14F);
            this.btTraspaso.ForeColor = System.Drawing.Color.White;
            this.btTraspaso.Location = new System.Drawing.Point(303, 81);
            this.btTraspaso.Name = "btTraspaso";
            this.btTraspaso.Size = new System.Drawing.Size(102, 31);
            this.btTraspaso.TabIndex = 14;
            this.btTraspaso.Text = "Traspaso";
            this.btTraspaso.UseVisualStyleBackColor = false;
            this.btTraspaso.Click += new System.EventHandler(this.btTraspaso_Click);
            // 
            // btVender
            // 
            this.btVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.btVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVender.FlatAppearance.BorderSize = 0;
            this.btVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVender.Font = new System.Drawing.Font("Calibri", 14F);
            this.btVender.ForeColor = System.Drawing.Color.White;
            this.btVender.Location = new System.Drawing.Point(303, 32);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(102, 31);
            this.btVender.TabIndex = 13;
            this.btVender.Text = "Vender";
            this.btVender.UseVisualStyleBackColor = false;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // lbMen
            // 
            this.lbMen.AutoSize = true;
            this.lbMen.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbMen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(70)))));
            this.lbMen.Location = new System.Drawing.Point(20, 276);
            this.lbMen.Name = "lbMen";
            this.lbMen.Size = new System.Drawing.Size(0, 19);
            this.lbMen.TabIndex = 12;
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtDate.Location = new System.Drawing.Point(81, 209);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(203, 27);
            this.dtDate.TabIndex = 11;
            // 
            // txTelefono
            // 
            this.txTelefono.Font = new System.Drawing.Font("Calibri", 12F);
            this.txTelefono.Location = new System.Drawing.Point(81, 161);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(203, 27);
            this.txTelefono.TabIndex = 9;
            // 
            // txCed
            // 
            this.txCed.Font = new System.Drawing.Font("Calibri", 12F);
            this.txCed.Location = new System.Drawing.Point(81, 121);
            this.txCed.Name = "txCed";
            this.txCed.Size = new System.Drawing.Size(203, 27);
            this.txCed.TabIndex = 8;
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Calibri", 12F);
            this.txNombre.Location = new System.Drawing.Point(81, 78);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(203, 27);
            this.txNombre.TabIndex = 7;
            // 
            // txChasis
            // 
            this.txChasis.Font = new System.Drawing.Font("Calibri", 12F);
            this.txChasis.Location = new System.Drawing.Point(81, 36);
            this.txChasis.Name = "txChasis";
            this.txChasis.Size = new System.Drawing.Size(203, 27);
            this.txChasis.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chasis:";
            // 
            // InventarioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(440, 360);
            this.Controls.Add(this.gbVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioVenta";
            this.Text = "InventarioVenta";
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.Label lbMen;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txCed;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txChasis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTraspaso;
    }
}