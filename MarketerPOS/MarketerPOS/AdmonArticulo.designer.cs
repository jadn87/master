namespace MarketerPOS
{
    partial class AdmonArticulo
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
            System.Windows.Forms.Label eanLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listAdmonArticulos_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eanTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.btnEditArticulo = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.EAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            eanLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listAdmonArticulos_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAdmonArticulos_dgv
            // 
            this.listAdmonArticulos_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listAdmonArticulos_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listAdmonArticulos_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAdmonArticulos_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listAdmonArticulos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAdmonArticulos_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EAN,
            this.DESCRIPCION,
            this.VALOR});
            this.listAdmonArticulos_dgv.Location = new System.Drawing.Point(12, 30);
            this.listAdmonArticulos_dgv.Name = "listAdmonArticulos_dgv";
            this.listAdmonArticulos_dgv.Size = new System.Drawing.Size(546, 422);
            this.listAdmonArticulos_dgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarArticulo);
            this.groupBox1.Controls.Add(eanLabel);
            this.groupBox1.Controls.Add(this.btnEditArticulo);
            this.groupBox1.Controls.Add(this.eanTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(577, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración de Prendas";
            // 
            // eanLabel
            // 
            eanLabel.AutoSize = true;
            eanLabel.Location = new System.Drawing.Point(19, 44);
            eanLabel.Name = "eanLabel";
            eanLabel.Size = new System.Drawing.Size(32, 13);
            eanLabel.TabIndex = 0;
            eanLabel.Text = "EAN:";
            // 
            // eanTextBox
            // 
            this.eanTextBox.Location = new System.Drawing.Point(105, 41);
            this.eanTextBox.Name = "eanTextBox";
            this.eanTextBox.Size = new System.Drawing.Size(100, 20);
            this.eanTextBox.TabIndex = 1;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(19, 70);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(83, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "DESCRIPCIÓN:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(105, 67);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(207, 20);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(19, 96);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(46, 13);
            valorLabel.TabIndex = 4;
            valorLabel.Text = "VALOR:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(105, 93);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 5;
            // 
            // btnEditArticulo
            // 
            this.btnEditArticulo.Enabled = false;
            this.btnEditArticulo.Location = new System.Drawing.Point(105, 140);
            this.btnEditArticulo.Name = "btnEditArticulo";
            this.btnEditArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEditArticulo.TabIndex = 2;
            this.btnEditArticulo.Text = "Editar";
            this.btnEditArticulo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(225, 140);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarArticulo.TabIndex = 3;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            // 
            // EAN
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.EAN.DefaultCellStyle = dataGridViewCellStyle2;
            this.EAN.HeaderText = "EAN";
            this.EAN.Name = "EAN";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 300;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // AdmonArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listAdmonArticulos_dgv);
            this.Name = "AdmonArticulo";
            this.Text = "AdmonArticulo";
            this.Load += new System.EventHandler(this.AdmonArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAdmonArticulos_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listAdmonArticulos_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox eanTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.Button btnEditArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}