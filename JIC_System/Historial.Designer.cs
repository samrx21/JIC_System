namespace JIC_System
{
    partial class Historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.txSumaValor = new System.Windows.Forms.TextBox();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.btVentasFech = new System.Windows.Forms.Button();
            this.btFiltrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txCant = new System.Windows.Forms.TextBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.rbMotocarro = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.EnableHeadersVisualStyles = false;
            this.dataGridViewVentas.Location = new System.Drawing.Point(40, 70);
            this.dataGridViewVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.ReadOnly = true;
            this.dataGridViewVentas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVentas.Size = new System.Drawing.Size(803, 304);
            this.dataGridViewVentas.TabIndex = 0;
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(40, 39);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(207, 27);
            this.txSearch.TabIndex = 1;
            // 
            // txSumaValor
            // 
            this.txSumaValor.Location = new System.Drawing.Point(73, 501);
            this.txSumaValor.Name = "txSumaValor";
            this.txSumaValor.ReadOnly = true;
            this.txSumaValor.Size = new System.Drawing.Size(196, 27);
            this.txSumaValor.TabIndex = 3;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(73, 433);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerInicio.TabIndex = 4;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(346, 433);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerFin.TabIndex = 5;
            // 
            // btVentasFech
            // 
            this.btVentasFech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.btVentasFech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVentasFech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVentasFech.Font = new System.Drawing.Font("Calibri", 14F);
            this.btVentasFech.ForeColor = System.Drawing.Color.White;
            this.btVentasFech.Location = new System.Drawing.Point(442, 491);
            this.btVentasFech.Name = "btVentasFech";
            this.btVentasFech.Size = new System.Drawing.Size(104, 37);
            this.btVentasFech.TabIndex = 6;
            this.btVentasFech.Text = "Buscar";
            this.btVentasFech.UseVisualStyleBackColor = false;
            this.btVentasFech.Click += new System.EventHandler(this.btVentasFech_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFiltrar.FlatAppearance.BorderSize = 0;
            this.btFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltrar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btFiltrar.IconColor = System.Drawing.Color.MediumOrchid;
            this.btFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btFiltrar.IconSize = 32;
            this.btFiltrar.Location = new System.Drawing.Point(249, 33);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(44, 37);
            this.btFiltrar.TabIndex = 7;
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ventas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(651, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Historial de Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ventas por periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(289, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad:";
            // 
            // txCant
            // 
            this.txCant.Location = new System.Drawing.Point(293, 501);
            this.txCant.Name = "txCant";
            this.txCant.ReadOnly = true;
            this.txCant.Size = new System.Drawing.Size(67, 27);
            this.txCant.TabIndex = 14;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbMotocarro);
            this.gbTipo.Controls.Add(this.rbMoto);
            this.gbTipo.ForeColor = System.Drawing.Color.White;
            this.gbTipo.Location = new System.Drawing.Point(561, 418);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(180, 55);
            this.gbTipo.TabIndex = 15;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Seleccione tipo de Moto";
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(7, 21);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(61, 23);
            this.rbMoto.TabIndex = 0;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Moto";
            this.rbMoto.UseVisualStyleBackColor = true;
            // 
            // rbMotocarro
            // 
            this.rbMotocarro.AutoSize = true;
            this.rbMotocarro.Location = new System.Drawing.Point(74, 21);
            this.rbMotocarro.Name = "rbMotocarro";
            this.rbMotocarro.Size = new System.Drawing.Size(94, 23);
            this.rbMotocarro.TabIndex = 1;
            this.rbMotocarro.TabStop = true;
            this.rbMotocarro.Text = "Motocarro";
            this.rbMotocarro.UseVisualStyleBackColor = true;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.txCant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.btVentasFech);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.txSumaValor);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.dataGridViewVentas);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.TextBox txSumaValor;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Button btVentasFech;
        private FontAwesome.Sharp.IconButton btFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txCant;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbMotocarro;
        private System.Windows.Forms.RadioButton rbMoto;
    }
}