namespace JIC_System
{
    partial class Creditos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.lbMen = new System.Windows.Forms.Label();
            this.btFiltrar = new FontAwesome.Sharp.IconButton();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDatos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.EnableHeadersVisualStyles = false;
            this.dataGridViewDatos.Location = new System.Drawing.Point(44, 105);
            this.dataGridViewDatos.MultiSelect = false;
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.ReadOnly = true;
            this.dataGridViewDatos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatos.Size = new System.Drawing.Size(1001, 303);
            this.dataGridViewDatos.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(21)))), ((int)(((byte)(143)))));
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.ForeColor = System.Drawing.Color.White;
            this.buttonActualizar.Location = new System.Drawing.Point(931, 414);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(114, 49);
            this.buttonActualizar.TabIndex = 1;
            this.buttonActualizar.Text = "Pagar Cuota";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // lbMen
            // 
            this.lbMen.AutoSize = true;
            this.lbMen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(70)))));
            this.lbMen.Location = new System.Drawing.Point(61, 438);
            this.lbMen.Name = "lbMen";
            this.lbMen.Size = new System.Drawing.Size(0, 19);
            this.lbMen.TabIndex = 2;
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
            this.btFiltrar.Location = new System.Drawing.Point(253, 65);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(44, 37);
            this.btFiltrar.TabIndex = 9;
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(44, 71);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(207, 27);
            this.txSearch.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(880, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Creditos Activos";
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1073, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.lbMen);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dataGridViewDatos);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Creditos";
            this.Text = "Creditos";
            this.Load += new System.EventHandler(this.Creditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label lbMen;
        private FontAwesome.Sharp.IconButton btFiltrar;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Label label4;
    }
}