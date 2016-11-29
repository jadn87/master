namespace MarketerPOS
{
    partial class Movimientos
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
            this.dateFrom_picker = new System.Windows.Forms.DateTimePicker();
            this.dateTo_picker = new System.Windows.Forms.DateTimePicker();
            this.lbl_tipoMov = new System.Windows.Forms.Label();
            this.lbl_FecDesde = new System.Windows.Forms.Label();
            this.lbl_FecHasta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COD_PRENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFrom_picker
            // 
            this.dateFrom_picker.Location = new System.Drawing.Point(122, 58);
            this.dateFrom_picker.Name = "dateFrom_picker";
            this.dateFrom_picker.Size = new System.Drawing.Size(200, 20);
            this.dateFrom_picker.TabIndex = 2;
            // 
            // dateTo_picker
            // 
            this.dateTo_picker.Location = new System.Drawing.Point(122, 102);
            this.dateTo_picker.Name = "dateTo_picker";
            this.dateTo_picker.Size = new System.Drawing.Size(200, 20);
            this.dateTo_picker.TabIndex = 3;
            // 
            // lbl_tipoMov
            // 
            this.lbl_tipoMov.AutoSize = true;
            this.lbl_tipoMov.Location = new System.Drawing.Point(21, 22);
            this.lbl_tipoMov.Name = "lbl_tipoMov";
            this.lbl_tipoMov.Size = new System.Drawing.Size(88, 13);
            this.lbl_tipoMov.TabIndex = 4;
            this.lbl_tipoMov.Text = "Tipo Movimiento:";
            // 
            // lbl_FecDesde
            // 
            this.lbl_FecDesde.AutoSize = true;
            this.lbl_FecDesde.Location = new System.Drawing.Point(24, 62);
            this.lbl_FecDesde.Name = "lbl_FecDesde";
            this.lbl_FecDesde.Size = new System.Drawing.Size(74, 13);
            this.lbl_FecDesde.TabIndex = 5;
            this.lbl_FecDesde.Text = "Fecha Desde:";
            // 
            // lbl_FecHasta
            // 
            this.lbl_FecHasta.AutoSize = true;
            this.lbl_FecHasta.Location = new System.Drawing.Point(24, 102);
            this.lbl_FecHasta.Name = "lbl_FecHasta";
            this.lbl_FecHasta.Size = new System.Drawing.Size(71, 13);
            this.lbl_FecHasta.TabIndex = 6;
            this.lbl_FecHasta.Text = "Fecha Hasta:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(27, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_PRENDA,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.TOTAL});
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // COD_PRENDA
            // 
            this.COD_PRENDA.HeaderText = "CÓDIGO PRENDA";
            this.COD_PRENDA.Name = "COD_PRENDA";
            this.COD_PRENDA.Width = 150;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 300;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "VALOR TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 150;
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_FecHasta);
            this.Controls.Add(this.lbl_FecDesde);
            this.Controls.Add(this.lbl_tipoMov);
            this.Controls.Add(this.dateTo_picker);
            this.Controls.Add(this.dateFrom_picker);
            this.Name = "Movimientos";
            this.Text = "Movimientos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateFrom_picker;
        private System.Windows.Forms.DateTimePicker dateTo_picker;
        private System.Windows.Forms.Label lbl_tipoMov;
        private System.Windows.Forms.Label lbl_FecDesde;
        private System.Windows.Forms.Label lbl_FecHasta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PRENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;

    }
}