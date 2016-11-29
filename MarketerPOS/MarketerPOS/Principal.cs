using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Entities;
using System.Configuration;

namespace MarketerPOS
{
    public partial class Principal : Form
    {
        ContextDB ut;
        bool flagClient = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marketerPOSDataSet);

        }

        private void init()
        {
            //panel registro prenda
            param_cantidad.Value = 1;
            tipoPrendaText.Text = String.Empty;
            precioText.Text = String.Empty;
            observacionText.Text = String.Empty;

            //panel cliente
            cedulaTextBox.Text = String.Empty;
            nombreTextBox.Text = String.Empty;
            apellidoTextBox.Text = String.Empty;
            telefonoTextBox.Text = String.Empty;
            direccionTextBox.Text = String.Empty;
            correoTextBox.Text = String.Empty;

            nombreTextBox.Enabled = true;
            apellidoTextBox.Enabled = true;
            correoTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;

            //lista de pedido
            listaprendas_dgv.Rows.Clear();

            lblTotal.Text = "";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // TODO: esta línea de código carga datos en la tabla 'lAUNDRY_COLDataSet.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.marketerPOSDataSet.articulos);
            // TODO: esta línea de código carga datos en la tabla 'lAUNDRY_COLDataSet.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.lAUNDRY_COLDataSet.clientes);

            ut = new ContextDB();
            ut.autocomplete(tipoPrendaText);
            
        }
        

        private void tipoPrendaText_TextChanged(object sender, EventArgs e)
        {
            ut = new ContextDB();
            precioText.Text = ut.calculateVal(tipoPrendaText.Text);
        }

        private void linkBuscarId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String msg_error = "Debe ingresar un numero de cédula válido";
            Regex reg = new Regex("/^[0-9]+$/");
            try
            {
                if (cedulaTextBox.Text.Trim().Equals("") || (cedulaTextBox.Text.Trim().Length < 6 || cedulaTextBox.Text.Trim().Length > 10) ||
                    (Convert.ToInt32(cedulaTextBox.Text.Trim()) == 0))
                {
                    MessageBox.Show(msg_error);
                    cedulaTextBox.Text = "";
                    return;
                }
            }
            catch (Exception) { MessageBox.Show(msg_error); cedulaTextBox.Text = ""; return; }
            

            try
            {
                ut = new ContextDB();
                decimal idCliente = Decimal.Parse(cedulaTextBox.Text.Trim());
                Cliente resp = ut.findClient(idCliente);

                if (resp.NOMBRE != null)
                {
                    flagClient = true;
                    //id_cliente = resp.ID;
                    nombreTextBox.Text = resp.NOMBRE;
                    apellidoTextBox.Text = resp.APELLIDO;
                    correoTextBox.Text = resp.EMAIL;
                    direccionTextBox.Text = resp.DIRECCION;
                    telefonoTextBox.Text = resp.TELEFONO;

                    //nombreTextBox.Enabled=false;
                    //apellidoTextBox.Enabled = false;
                    //correoTextBox.Enabled = false;
                    //direccionTextBox.Enabled = false;
                    //telefonoTextBox.Enabled = false;

                }
                else {
                    MessageBox.Show("No se encontro informacion del cliente " + cedulaTextBox.Text.Trim());
                    return;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error consultando informacion del cliente. "+ ex.ToString());
            }

        }

        /// <summary>
        /// funcion encargada de cargar registro al datagridview, debe hacer tratamiento de algunos datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_prenda_Click(object sender, EventArgs e)
        {
            
            //validar que eston los datos plenamente diligenciados            
            if (param_cantidad.Value <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.");
                return;
            }
            if(tipoPrendaText.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese una descripción de prenda válida.");
                return;
            }
            //Los demas parametros no se validan porque el usuario puede crear elementos que no esten registrados en la BD.
            decimal valorTotal = 0;
            decimal precioFinal = 0;
            if(!precioText.Text.Equals(""))
            precioFinal = decimal.Parse(precioText.Text) * param_cantidad.Value;


            listaprendas_dgv.Rows.Add(param_cantidad.Value, ut.consultaEan(tipoPrendaText.Text)+" - "+tipoPrendaText.Text, precioFinal.ToString("#,##0"), observacionText.Text, "Borrar"); 

            //limpiar variables de ingreso
            param_cantidad.Value = 1;
            tipoPrendaText.Text = String.Empty;
            precioText.Text = String.Empty;
            observacionText.Text = String.Empty;

            //calcular el precio total de la factura
            for (int i = 0; i < listaprendas_dgv.Rows.Count; i++)
            {
                if (this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value != null)
                {
                    decimal val = Convert.ToDecimal(this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value);
                    valorTotal = valorTotal + val;
                }
            }
            lblTotal.Text = "$ " + valorTotal.ToString("#,##0");
        }

        /// <summary>
        /// Metodo encargado de borrar del datagridview el registro seleccionado por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaprendas_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal valorTotal = 0;
            //boton borrar es el que aparece en la posicion de columna #4 y Row no debe ser vacio            
            if (e.ColumnIndex == 4 && this.listaprendas_dgv.Rows[e.RowIndex].Cells["CANTIDAD"].Value != null)
            {
                if (this.listaprendas_dgv.SelectedRows.Count > 0)
                {
                    listaprendas_dgv.Rows.RemoveAt(e.RowIndex);
                    listaprendas_dgv.Refresh();
                }
            }

            //calcular el precio total de la factura
            for (int i = 0; i < listaprendas_dgv.Rows.Count; i++)
            {
                if (this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value != null)
                {
                    decimal val = Convert.ToDecimal(this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value);
                    valorTotal = valorTotal + val;
                }
            }
            lblTotal.Text = "$ " + valorTotal.ToString("#,##0"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             lblTimer.Text= DateTime.Now.ToLongTimeString();
        }


        private void btn_guardarFact_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion registro cliente
                if (cedulaTextBox.Text.Trim().Equals("") || nombreTextBox.Text.Equals("") || apellidoTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Por favor ingrese los datos del cliente: cédula, nombre(s), apellido(s).");
                    return;
                }

                //validacion registro prendas
                if (listaprendas_dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor ingrese y/o registre un pedido válido.");
                    return;
                }
                if (listaprendas_dgv.Rows.Count >= 1)
                {
                    if (this.listaprendas_dgv.Rows[0].Cells["PRECIO"].Value == null)
                    {
                        MessageBox.Show("Por favor ingrese y/o registre un pedido válido.");
                        return;
                    }
                }

                


                //creamos el cliente si se trata de uno nuevo
                if (!flagClient) 
                {
                    Cliente newCliente = new Cliente()
                    {
                        CEDULA = Convert.ToDecimal(cedulaTextBox.Text),
                        NOMBRE = nombreTextBox.Text.ToUpper(),
                        APELLIDO = apellidoTextBox.Text.ToUpper(),
                        TELEFONO = telefonoTextBox.Text,
                        EMAIL = correoTextBox.Text,
                        DIRECCION = direccionTextBox.Text
                    };
                    //manda a crear el cliente en la BD y continua el proceso
                    ut.crearCliente(newCliente);
                }


                //################## LLAVE DE LAS TABLAS TICKET Y TICKETITEMS
                //se arma el consecutivo de numero de ticket que debe ser igual para la tabla ticketitems y ticket
                decimal ticketnumber = ut.GetNextTicketNumberValue();
                int localid = Convert.ToInt16(ConfigurationManager.AppSettings["localid"].ToString());
                DateTime current_date = DateTime.Now;


                //################## TICKET
                Ticket tk = new Ticket();
                tk.LOCAL_ID = localid;
                tk.NUM_TICKET = ticketnumber;
                tk.ESTADO = estadoTicket.Ingresado;
                tk.FEC_REGISTRO = current_date;
                tk.TIPO_DOC = tipoTransaccion.Venta;
                tk.CLIENTE_ID = Convert.ToDecimal(cedulaTextBox.Text);
                
                decimal valorTotal=0;
                //calcular el precio total de la factura
                for (int i = 0; i < listaprendas_dgv.Rows.Count; i++)
                {
                    if (this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value != null)
                    {
                        decimal val = Convert.ToDecimal(this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value);
                        valorTotal = valorTotal + val;
                    }
                }

                tk.TOTAL = valorTotal;
                tk.USUARIO = 12345;

                ut.crearTicket(tk);

                //################## TICKETITEMS
                TicketItem ti;

                for (int i = 0; i < this.listaprendas_dgv.Rows.Count; i++)
                {
                    if (this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value != null)
                    {
                        string[] detPrenda = Convert.ToString(this.listaprendas_dgv.Rows[i].Cells["TIPO_PRENDA"].Value).Split('-');
                        string codEan = detPrenda[0].Trim().ToString();
                        string tipoPrenda = detPrenda[1].Trim().ToString();

                        ti = new TicketItem();
                        ti.LOCAL_ID = localid;
                        ti.NUM_TICKET = ticketnumber;
                        ti.EAN = codEan;//****** debe ir el codigo ean
                        ti.CANTIDAD = Convert.ToInt16(this.listaprendas_dgv.Rows[i].Cells["CANTIDAD"].Value);
                        ti.DESCRIPCION = tipoPrenda;
                        ti.FEC_REGISTRO = current_date;
                        ti.VAL_UNITARIO = Convert.ToDecimal(this.listaprendas_dgv.Rows[i].Cells["PRECIO"].Value) / ti.CANTIDAD;
                        ti.OBSERVACION = Convert.ToString(this.listaprendas_dgv.Rows[i].Cells["OBSERVACIONES"].Value);

                        ut.crearTicketItems(ti);
                    }
                }


                init();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presentó un error al generar la factura. "+ ex.ToString());
            }

        }

        private void btn_BorrarIngreso_Click(object sender, EventArgs e)
        {
            /*
            //limpiar variables de ingreso Prenda
            param_cantidad.Value = 1;
            tipoPrendaText.Text = String.Empty;
            precioText.Text = String.Empty;
            observacionText.Text = String.Empty;


            //id_cliente = resp.ID;
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            correoTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
            //---------------
            nombreTextBox.Enabled = true;
            apellidoTextBox.Enabled = true;
            correoTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            */
            init();


        }

                
        

    }
}
