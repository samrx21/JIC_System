namespace JIC_System
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwInventario = new System.Windows.Forms.DataGridView();
            this.cHASISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new JIC_System.DataSet1();
            this.iNVENTARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new JIC_System.DataSet1();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btVenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelInv = new System.Windows.Forms.Panel();
            this.iNVENTARIOTableAdapter = new JIC_System.DataSet1TableAdapters.INVENTARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // dgwInventario
            // 
            this.dgwInventario.AllowUserToAddRows = false;
            this.dgwInventario.AllowUserToDeleteRows = false;
            this.dgwInventario.AutoGenerateColumns = false;
            this.dgwInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgwInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHASISDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.mODELODataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.fECHAINDataGridViewTextBoxColumn,
            this.iDFACDataGridViewTextBoxColumn});
            this.dgwInventario.DataSource = this.iNVENTARIOBindingSource;
            this.dgwInventario.EnableHeadersVisualStyles = false;
            this.dgwInventario.Location = new System.Drawing.Point(31, 90);
            this.dgwInventario.Name = "dgwInventario";
            this.dgwInventario.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwInventario.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.dgwInventario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwInventario.Size = new System.Drawing.Size(603, 349);
            this.dgwInventario.TabIndex = 1;
            // 
            // cHASISDataGridViewTextBoxColumn
            // 
            this.cHASISDataGridViewTextBoxColumn.DataPropertyName = "CHASIS";
            this.cHASISDataGridViewTextBoxColumn.HeaderText = "CHASIS";
            this.cHASISDataGridViewTextBoxColumn.Name = "cHASISDataGridViewTextBoxColumn";
            this.cHASISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            this.mODELODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAINDataGridViewTextBoxColumn
            // 
            this.fECHAINDataGridViewTextBoxColumn.DataPropertyName = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.HeaderText = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.Name = "fECHAINDataGridViewTextBoxColumn";
            this.fECHAINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDFACDataGridViewTextBoxColumn
            // 
            this.iDFACDataGridViewTextBoxColumn.DataPropertyName = "IDFAC";
            this.iDFACDataGridViewTextBoxColumn.HeaderText = "FACTURA";
            this.iDFACDataGridViewTextBoxColumn.Name = "iDFACDataGridViewTextBoxColumn";
            this.iDFACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNVENTARIOBindingSource
            // 
            this.iNVENTARIOBindingSource.DataMember = "INVENTARIO";
            this.iNVENTARIOBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTARIOBindingSource1
            // 
            this.iNVENTARIOBindingSource1.DataMember = "INVENTARIO";
            this.iNVENTARIOBindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.btIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngresar.FlatAppearance.BorderSize = 0;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btIngresar.ForeColor = System.Drawing.Color.White;
            this.btIngresar.Location = new System.Drawing.Point(296, 56);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(71, 31);
            this.btIngresar.TabIndex = 2;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btVenta
            // 
            this.btVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.btVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVenta.FlatAppearance.BorderSize = 0;
            this.btVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenta.Font = new System.Drawing.Font("Calibri", 12F);
            this.btVenta.ForeColor = System.Drawing.Color.White;
            this.btVenta.Location = new System.Drawing.Point(373, 56);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(71, 31);
            this.btVenta.TabIndex = 13;
            this.btVenta.Text = "Vender";
            this.btVenta.UseVisualStyleBackColor = false;
            this.btVenta.Click += new System.EventHandler(this.btVenta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(24)))), ((int)(((byte)(155)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(450, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Credito";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelInv
            // 
            this.PanelInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PanelInv.Location = new System.Drawing.Point(647, 80);
            this.PanelInv.Name = "PanelInv";
            this.PanelInv.Size = new System.Drawing.Size(447, 359);
            this.PanelInv.TabIndex = 15;
            // 
            // iNVENTARIOTableAdapter
            // 
            this.iNVENTARIOTableAdapter.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1122, 557);
            this.Controls.Add(this.PanelInv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btVenta);
            this.Controls.Add(this.dgwInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIngresar);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwInventario;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.Panel PanelInv;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource iNVENTARIOBindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource iNVENTARIOBindingSource1;
        private DataSet1TableAdapters.INVENTARIOTableAdapter iNVENTARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHASISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFACDataGridViewTextBoxColumn;
    }
}