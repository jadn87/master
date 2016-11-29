namespace MarketerPOS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLblOlvidoClave = new System.Windows.Forms.LinkLabel();
            this.textPassw = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConex = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marketerPOSDataSet = new MarketerPOS.MarketerPOSDataSet();
            this.usuariosTableAdapter = new MarketerPOS.MarketerPOSDataSetTableAdapters.usuariosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketerPOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLblOlvidoClave);
            this.panel1.Controls.Add(this.textPassw);
            this.panel1.Controls.Add(this.textUsuario);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblConex);
            this.panel1.Controls.Add(this.btnIngreso);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 211);
            this.panel1.TabIndex = 0;
            // 
            // linkLblOlvidoClave
            // 
            this.linkLblOlvidoClave.AutoSize = true;
            this.linkLblOlvidoClave.Location = new System.Drawing.Point(254, 185);
            this.linkLblOlvidoClave.Name = "linkLblOlvidoClave";
            this.linkLblOlvidoClave.Size = new System.Drawing.Size(97, 13);
            this.linkLblOlvidoClave.TabIndex = 7;
            this.linkLblOlvidoClave.TabStop = true;
            this.linkLblOlvidoClave.Text = "Cambiar su clave ?";
            // 
            // textPassw
            // 
            this.textPassw.Location = new System.Drawing.Point(148, 85);
            this.textPassw.Name = "textPassw";
            this.textPassw.Size = new System.Drawing.Size(172, 20);
            this.textPassw.TabIndex = 5;
            this.textPassw.UseSystemPasswordChar = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(147, 58);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(173, 20);
            this.textUsuario.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(54, 88);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(68, 61);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblConex
            // 
            this.lblConex.AutoSize = true;
            this.lblConex.Location = new System.Drawing.Point(129, 16);
            this.lblConex.Name = "lblConex";
            this.lblConex.Size = new System.Drawing.Size(129, 13);
            this.lblConex.TabIndex = 1;
            this.lblConex.Text = "INGRESAR AL SISTEMA";
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(94, 124);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(204, 23);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "CONECTAR";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "usuarios";
            this.bindingSource1.DataSource = this.marketerPOSDataSet;
            // 
            // marketerPOSDataSet
            // 
            this.marketerPOSDataSet.DataSetName = "MarketerPOSDataSet";
            this.marketerPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(373, 208);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketerPOSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPassw;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConex;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.LinkLabel linkLblOlvidoClave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MarketerPOSDataSet marketerPOSDataSet;
        private MarketerPOSDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;

    }
}