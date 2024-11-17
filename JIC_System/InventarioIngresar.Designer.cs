namespace JIC_System
{
    partial class InventarioIngresar
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
            this.components = new System.ComponentModel.Container();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.lbMen = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lbFactura = new System.Windows.Forms.ListBox();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new JIC_System.DataSet1();
            this.txValor = new System.Windows.Forms.TextBox();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txChasis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fACTURATableAdapter = new JIC_System.DataSet1TableAdapters.FACTURATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.ListBox();
            this.gbIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.lbTipo);
            this.gbIngresar.Controls.Add(this.label1);
            this.gbIngresar.Controls.Add(this.btIngresar);
            this.gbIngresar.Controls.Add(this.lbMen);
            this.gbIngresar.Controls.Add(this.dtDate);
            this.gbIngresar.Controls.Add(this.lbFactura);
            this.gbIngresar.Controls.Add(this.txValor);
            this.gbIngresar.Controls.Add(this.txModelo);
            this.gbIngresar.Controls.Add(this.txNombre);
            this.gbIngresar.Controls.Add(this.txChasis);
            this.gbIngresar.Controls.Add(this.label7);
            this.gbIngresar.Controls.Add(this.label6);
            this.gbIngresar.Controls.Add(this.label5);
            this.gbIngresar.Controls.Add(this.label4);
            this.gbIngresar.Controls.Add(this.label3);
            this.gbIngresar.Controls.Add(this.label2);
            this.gbIngresar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.gbIngresar.ForeColor = System.Drawing.Color.White;
            this.gbIngresar.Location = new System.Drawing.Point(2, 0);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(427, 356);
            this.gbIngresar.TabIndex = 4;
            this.gbIngresar.TabStop = false;
            this.gbIngresar.Text = "Ingresar Moto";
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.btIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngresar.FlatAppearance.BorderSize = 0;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btIngresar.ForeColor = System.Drawing.Color.White;
            this.btIngresar.Location = new System.Drawing.Point(303, 32);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(102, 31);
            this.btIngresar.TabIndex = 13;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // lbMen
            // 
            this.lbMen.AutoSize = true;
            this.lbMen.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbMen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(70)))));
            this.lbMen.Location = new System.Drawing.Point(20, 313);
            this.lbMen.Name = "lbMen";
            this.lbMen.Size = new System.Drawing.Size(0, 19);
            this.lbMen.TabIndex = 12;
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtDate.Location = new System.Drawing.Point(81, 234);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(203, 27);
            this.dtDate.TabIndex = 11;
            // 
            // lbFactura
            // 
            this.lbFactura.DataSource = this.fACTURABindingSource;
            this.lbFactura.DisplayMember = "ID";
            this.lbFactura.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbFactura.FormattingEnabled = true;
            this.lbFactura.ItemHeight = 19;
            this.lbFactura.Location = new System.Drawing.Point(81, 272);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(203, 61);
            this.lbFactura.TabIndex = 10;
            this.lbFactura.ValueMember = "ID";
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            this.fACTURABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txValor
            // 
            this.txValor.Font = new System.Drawing.Font("Calibri", 12F);
            this.txValor.Location = new System.Drawing.Point(81, 194);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(203, 27);
            this.txValor.TabIndex = 9;
            // 
            // txModelo
            // 
            this.txModelo.Font = new System.Drawing.Font("Calibri", 12F);
            this.txModelo.Location = new System.Drawing.Point(81, 121);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(203, 27);
            this.txModelo.TabIndex = 8;
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
            this.label7.Location = new System.Drawing.Point(25, 240);
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
            this.label6.Location = new System.Drawing.Point(14, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chasis:";
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo:";
            // 
            // lbTipo
            // 
            this.lbTipo.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbTipo.FormattingEnabled = true;
            this.lbTipo.ItemHeight = 19;
            this.lbTipo.Items.AddRange(new object[] {
            "Moto",
            "Motocarro"});
            this.lbTipo.Location = new System.Drawing.Point(81, 157);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(203, 23);
            this.lbTipo.TabIndex = 15;
            // 
            // InventarioIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(433, 360);
            this.Controls.Add(this.gbIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioIngresar";
            this.Text = "InventarioIngresar";
            this.Load += new System.EventHandler(this.InventarioIngresar_Load);
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.Label lbMen;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.ListBox lbFactura;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txChasis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIngresar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private DataSet1TableAdapters.FACTURATableAdapter fACTURATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTipo;
    }
}