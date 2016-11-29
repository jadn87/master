namespace MarketerPOS
{
    partial class Principal
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkBuscarId = new System.Windows.Forms.LinkLabel();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketerPOSDataSet = new MarketerPOS.MarketerPOSDataSet();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.clientesTableAdapter = new MarketerPOS.MarketerPOSDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new MarketerPOS.MarketerPOSDataSetTableAdapters.TableAdapterManager();
            this.precioText = new System.Windows.Forms.TextBox();
            this.observacionText = new System.Windows.Forms.TextBox();
            this.tipoPrendaText = new System.Windows.Forms.TextBox();
            this.param_cantidad = new System.Windows.Forms.NumericUpDown();
            this.listaprendas_dgv = new System.Windows.Forms.DataGridView();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PRENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.add_prenda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosTableAdapter = new MarketerPOS.MarketerPOSDataSetTableAdapters.articulosTableAdapter();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn_guardarFact = new System.Windows.Forms.Button();
            this.btn_BorrarIngreso = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketerPOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaprendas_dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(22, 75);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(84, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "NOMBRE(S):";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(22, 46);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(65, 16);
            cedulaLabel.TabIndex = 0;
            cedulaLabel.Text = "CÉDULA:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(21, 133);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(82, 16);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "TELÉFONO:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(22, 194);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(55, 16);
            correoLabel.TabIndex = 11;
            correoLabel.Text = "EMAIL:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(22, 164);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(85, 16);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "DIRECCIÓN:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(20, 104);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(92, 16);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "APELLIDO(S):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.linkBuscarId);
            this.groupBox1.Controls.Add(this.cedulaTextBox);
            this.groupBox1.Controls.Add(this.correoTextBox);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(this.apellidoTextBox);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(apellidoLabel);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(cedulaLabel);
            this.groupBox1.Controls.Add(correoLabel);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(443, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // linkBuscarId
            // 
            this.linkBuscarId.AutoSize = true;
            this.linkBuscarId.Location = new System.Drawing.Point(245, 46);
            this.linkBuscarId.Name = "linkBuscarId";
            this.linkBuscarId.Size = new System.Drawing.Size(60, 16);
            this.linkBuscarId.TabIndex = 2;
            this.linkBuscarId.TabStop = true;
            this.linkBuscarId.Text = "BUSCAR";
            this.linkBuscarId.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBuscarId_LinkClicked);
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(108, 43);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(109, 22);
            this.cedulaTextBox.TabIndex = 1;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.marketerPOSDataSet;
            // 
            // marketerPOSDataSet
            // 
            this.marketerPOSDataSet.DataSetName = "MarketerPOSDataSet";
            this.marketerPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(108, 190);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(217, 22);
            this.correoTextBox.TabIndex = 12;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(108, 160);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(217, 22);
            this.direccionTextBox.TabIndex = 10;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(108, 130);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(109, 22);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(108, 101);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(217, 22);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(108, 72);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(217, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articulosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.localesTableAdapter = null;
            this.tableAdapterManager.parametrosTableAdapter = null;
            this.tableAdapterManager.ticketitemsTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.tipoDocumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MarketerPOS.MarketerPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // precioText
            // 
            this.precioText.Enabled = false;
            this.precioText.Location = new System.Drawing.Point(128, 89);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(100, 22);
            this.precioText.TabIndex = 5;
            // 
            // observacionText
            // 
            this.observacionText.Location = new System.Drawing.Point(128, 120);
            this.observacionText.Multiline = true;
            this.observacionText.Name = "observacionText";
            this.observacionText.Size = new System.Drawing.Size(217, 59);
            this.observacionText.TabIndex = 7;
            // 
            // tipoPrendaText
            // 
            this.tipoPrendaText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipoPrendaText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tipoPrendaText.Location = new System.Drawing.Point(128, 59);
            this.tipoPrendaText.Name = "tipoPrendaText";
            this.tipoPrendaText.Size = new System.Drawing.Size(217, 22);
            this.tipoPrendaText.TabIndex = 3;
            this.tipoPrendaText.TextChanged += new System.EventHandler(this.tipoPrendaText_TextChanged);
            // 
            // param_cantidad
            // 
            this.param_cantidad.Location = new System.Drawing.Point(128, 29);
            this.param_cantidad.Name = "param_cantidad";
            this.param_cantidad.Size = new System.Drawing.Size(51, 22);
            this.param_cantidad.TabIndex = 1;
            this.param_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listaprendas_dgv
            // 
            this.listaprendas_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listaprendas_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaprendas_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaprendas_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaprendas_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaprendas_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CANTIDAD,
            this.TIPO_PRENDA,
            this.PRECIO,
            this.OBSERVACIONES,
            this.btn_borrar});
            this.listaprendas_dgv.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.listaprendas_dgv.Location = new System.Drawing.Point(102, 359);
            this.listaprendas_dgv.Name = "listaprendas_dgv";
            this.listaprendas_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaprendas_dgv.Size = new System.Drawing.Size(897, 201);
            this.listaprendas_dgv.TabIndex = 1;
            this.listaprendas_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaprendas_dgv_CellContentClick);
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 80;
            // 
            // TIPO_PRENDA
            // 
            this.TIPO_PRENDA.DataPropertyName = "prueba";
            this.TIPO_PRENDA.HeaderText = "TIPO DE PRENDA";
            this.TIPO_PRENDA.Name = "TIPO_PRENDA";
            this.TIPO_PRENDA.Width = 250;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OBSERVACIONES
            // 
            this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
            this.OBSERVACIONES.Name = "OBSERVACIONES";
            this.OBSERVACIONES.Width = 350;
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.HeaderText = "";
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.Width = 50;
            // 
            // add_prenda
            // 
            this.add_prenda.Location = new System.Drawing.Point(125, 187);
            this.add_prenda.Name = "add_prenda";
            this.add_prenda.Size = new System.Drawing.Size(75, 23);
            this.add_prenda.TabIndex = 8;
            this.add_prenda.Text = "Adicionar";
            this.add_prenda.UseVisualStyleBackColor = true;
            this.add_prenda.Click += new System.EventHandler(this.add_prenda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.precioText);
            this.groupBox2.Controls.Add(this.observacionText);
            this.groupBox2.Controls.Add(this.add_prenda);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tipoPrendaText);
            this.groupBox2.Controls.Add(this.param_cantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de Prendas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "OBSERVACION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRECIO UNIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANTIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO PRENDA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(399, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "LISTADO DE PRENDAS INGRESADAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataMember = "articulos";
            this.articulosBindingSource.DataSource = this.marketerPOSDataSet;
            // 
            // articulosTableAdapter
            // 
            this.articulosTableAdapter.ClearBeforeFill = true;
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaVenta.Location = new System.Drawing.Point(827, 567);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(72, 22);
            this.lblSumaVenta.TabIndex = 7;
            this.lblSumaVenta.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTotal.Location = new System.Drawing.Point(909, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTotal.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(821, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(898, 220);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 25);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "lblTimer";
            // 
            // btn_guardarFact
            // 
            this.btn_guardarFact.AutoEllipsis = true;
            this.btn_guardarFact.Location = new System.Drawing.Point(508, 620);
            this.btn_guardarFact.Name = "btn_guardarFact";
            this.btn_guardarFact.Size = new System.Drawing.Size(146, 23);
            this.btn_guardarFact.TabIndex = 11;
            this.btn_guardarFact.Text = "GENERAR FACTURA";
            this.btn_guardarFact.UseVisualStyleBackColor = true;
            this.btn_guardarFact.Click += new System.EventHandler(this.btn_guardarFact_Click);
            // 
            // btn_BorrarIngreso
            // 
            this.btn_BorrarIngreso.Location = new System.Drawing.Point(102, 566);
            this.btn_BorrarIngreso.Name = "btn_BorrarIngreso";
            this.btn_BorrarIngreso.Size = new System.Drawing.Size(110, 23);
            this.btn_BorrarIngreso.TabIndex = 12;
            this.btn_BorrarIngreso.Text = "Borrar Ingreso";
            this.btn_BorrarIngreso.UseVisualStyleBackColor = true;
            this.btn_BorrarIngreso.Click += new System.EventHandler(this.btn_BorrarIngreso_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1172, 729);
            this.Controls.Add(this.btn_BorrarIngreso);
            this.Controls.Add(this.btn_guardarFact);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSumaVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaprendas_dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketerPOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaprendas_dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MarketerPOSDataSet marketerPOSDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MarketerPOSDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private MarketerPOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.LinkLabel linkBuscarId;
        private System.Windows.Forms.DataGridView listaprendas_dgv;
        private System.Windows.Forms.Button add_prenda;
        private System.Windows.Forms.NumericUpDown param_cantidad;
        private System.Windows.Forms.TextBox tipoPrendaText;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.TextBox observacionText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private MarketerPOSDataSetTableAdapters.articulosTableAdapter articulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PRENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
        private System.Windows.Forms.DataGridViewButtonColumn btn_borrar;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btn_guardarFact;
        private System.Windows.Forms.Button btn_BorrarIngreso;
        private System.Windows.Forms.TextBox apellidoTextBox;
    }
}