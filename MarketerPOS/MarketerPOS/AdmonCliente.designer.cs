namespace MarketerPOS
{
    partial class AdmonCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listAdmonClientes_dgv = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listAdmonClientes_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración de Clientes";
            // 
            // listAdmonClientes_dgv
            // 
            this.listAdmonClientes_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAdmonClientes_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listAdmonClientes_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAdmonClientes_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.nomCliente,
            this.apeCliente,
            this.cedulaCliente,
            this.emailCliente,
            this.direccionCliente,
            this.telCliente});
            this.listAdmonClientes_dgv.Location = new System.Drawing.Point(32, 202);
            this.listAdmonClientes_dgv.Name = "listAdmonClientes_dgv";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAdmonClientes_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAdmonClientes_dgv.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.listAdmonClientes_dgv.Size = new System.Drawing.Size(892, 150);
            this.listAdmonClientes_dgv.TabIndex = 1;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.Width = 50;
            // 
            // nomCliente
            // 
            this.nomCliente.HeaderText = "NOMBRE(S)";
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.Width = 150;
            // 
            // apeCliente
            // 
            this.apeCliente.HeaderText = "APELLIDO(S)";
            this.apeCliente.Name = "apeCliente";
            this.apeCliente.Width = 150;
            // 
            // cedulaCliente
            // 
            this.cedulaCliente.HeaderText = "CÉDULA";
            this.cedulaCliente.Name = "cedulaCliente";
            // 
            // emailCliente
            // 
            this.emailCliente.HeaderText = "EMAIL";
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Width = 140;
            // 
            // direccionCliente
            // 
            this.direccionCliente.HeaderText = "DIRECCIÓN";
            this.direccionCliente.Name = "direccionCliente";
            this.direccionCliente.Width = 140;
            // 
            // telCliente
            // 
            this.telCliente.HeaderText = "TELÉFONO";
            this.telCliente.Name = "telCliente";
            // 
            // AdmonCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 402);
            this.Controls.Add(this.listAdmonClientes_dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdmonCliente";
            this.Text = "AdmonCliente";
            this.Load += new System.EventHandler(this.AdmonCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAdmonClientes_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listAdmonClientes_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telCliente;
    }
}